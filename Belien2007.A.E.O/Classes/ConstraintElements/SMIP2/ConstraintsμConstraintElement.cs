namespace Belien2007.A.E.O.Classes.ConstraintElements.SMIP2
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

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

            ImmutableList<Tuple<IsIndexElement, IjIndexElement, double>>.Builder builder = ImmutableList.CreateBuilder<Tuple<IsIndexElement, IjIndexElement, double>>();

            foreach (IsIndexElement sIndexElement in s.Value.Values)
            {
                foreach (IjIndexElement jIndexElement in j.Value.Where(y => A.GetElementAtAsint(y) == 1))
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

                    foreach (IkIndexElement kIndexElement in k.Value)
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

                    builder.Add(
                        Tuple.Create(
                            sIndexElement,
                            jIndexElement,
                            RHS_Sum));
                }
            }

            ImmutableList<Tuple<IsIndexElement, IjIndexElement, double>> RHS_Sums = builder.ToImmutableList();

            Expression RHS = Expression.Sum(
                sj.Value
                .Where(y => A.GetElementAtAsint(y.jIndexElement) == 1)
                .Select(
                    y =>
                    RHS_Sums.Where(w => w.Item1 == y.sIndexElement && w.Item2 == y.jIndexElement).Select(w => w.Item3).SingleOrDefault()
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