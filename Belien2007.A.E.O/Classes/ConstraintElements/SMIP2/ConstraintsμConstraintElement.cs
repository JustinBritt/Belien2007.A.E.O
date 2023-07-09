namespace Belien2007.A.E.O.Classes.ConstraintElements.SMIP2
{
    using System;
    using System.Linq;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using OPTANO.Modeling.Optimization;

    using Belien2007.A.E.O.Interfaces.ConstraintElements.SMIP2;
    using Belien2007.A.E.O.Interfaces.CrossJoins.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Stochastic;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.ActivePeriods;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonDayLengthOfStayProbabilities;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonLengthOfStayMaximums;
    using Belien2007.A.E.O.Interfaces.Parameters.Stochastic.SurgeonStateMaximumNumberPatients;
    using Belien2007.A.E.O.Interfaces.Parameters.Stochastic.SurgeonStateProbabilities;
    using Belien2007.A.E.O.Interfaces.Variables.Common;

    internal sealed class ConstraintsμConstraintElement : IConstraintsμConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ConstraintsμConstraintElement(
            IiIndexElement iIndexElement,
            Id d,
            Ii i,
            Ij j,
            Ik k,
            Is s,
            Isj sj,
            IA A,
            Ih h,
            Im m,
            IStochasticn n,
            Ip p,
            Ix x,
            Iμ μ)
        {
            Expression LHS = μ.Value[iIndexElement];

            RedBlackTree<IsIndexElement, RedBlackTree<IjIndexElement, double>> outerRedBlackTree = new RedBlackTree<IsIndexElement, RedBlackTree<IjIndexElement, double>>();

            foreach (IsIndexElement sIndexElement in s.Value.Values)
            {
                RedBlackTree<IjIndexElement, double> innerRedBlackTree = new RedBlackTree<IjIndexElement, double>();

                foreach (IjIndexElement jIndexElement in j.Value.Values.Where(y => A.GetElementAtAsint(y) == 1))
                {
                    int dLowerBound = m.GetElementAtAsint(sIndexElement) + 1;

                    if (jIndexElement.Key < iIndexElement.Key)
                    {
                        dLowerBound = iIndexElement.Key - jIndexElement.Key + 1;
                    }
                    else
                    {
                        dLowerBound = i.Getl() + iIndexElement.Key - jIndexElement.Key + 1;
                    }

                    double RHS_Sum = 0;

                    foreach (IkIndexElement kIndexElement in k.Value.Values)
                    {
                        for (int w = dLowerBound;
                            w <= m.GetElementAtAsint(sIndexElement);
                            w = w + 1)
                        {
                            RHS_Sum +=
                                (double)h.GetElementAtAsdecimal(
                                    sIndexElement,
                                    kIndexElement)
                                *
                                (double)p.GetElementAtAsdecimal(
                                    sIndexElement,
                                    d.GetElementAt(
                                        w))
                                *
                                (double)n.GetElementAtAsint(
                                    sIndexElement,
                                    kIndexElement)
                                *
                                (double)Math.Ceiling(
                                    (decimal)w
                                    /
                                    i.Getl());
                        }
                    }

                    innerRedBlackTree.Add(
                        jIndexElement,
                        RHS_Sum);
                }

                outerRedBlackTree.Add(
                    sIndexElement,
                    innerRedBlackTree);
            }

            Expression RHS = Expression.Sum(
                sj.Value
                .Where(y => A.GetElementAtAsint(y.jIndexElement) == 1)
                .Select(
                    y =>
                    outerRedBlackTree[y.sIndexElement][y.jIndexElement]
                    *
                    x.Value[
                        i.GetElementAt(
                            y.jIndexElement.Key),
                        y.sIndexElement]));

            this.Value = LHS == RHS;
        }

        public Constraint Value { get; }
    }
}