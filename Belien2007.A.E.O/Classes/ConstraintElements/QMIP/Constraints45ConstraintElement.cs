namespace Belien2007.A.E.O.Classes.ConstraintElements.QMIP
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Belien2007.A.E.O.Interfaces.ConstraintElements.QMIP;
    using Belien2007.A.E.O.Interfaces.CrossJoins.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.ActivePeriods;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonDayLengthOfStayProbabilities;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonLengthOfStayMaximums;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonMaximumNumberPatients;
    using Belien2007.A.E.O.Interfaces.Variables.Common;

    internal sealed class Constraints45ConstraintElement : IConstraints45ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints45ConstraintElement(
            IiIndexElement iIndexElement,
            Id d,
            Ii i,
            Ij j,
            Is s,
            Isj sj,
            IA A,
            Im m,
            ICommonn n,
            Ip p,
            Ix x,
            Iμ μ)
        {
            Expression LHS = μ.Value[iIndexElement];

            ImmutableList<Tuple<IsIndexElement, IjIndexElement, double>>.Builder builder = ImmutableList.CreateBuilder<Tuple<IsIndexElement, IjIndexElement, double>>();

            foreach (IsIndexElement sIndexElement in s.Value.Values)
            {
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

                    for (int w = dLowerBound;
                        w <= m.GetElementAtAsint(sIndexElement);
                        w = w + 1)
                    {
                        RHS_Sum +=
                            (double)p.GetElementAtAsdecimal(
                                sIndexElement,
                                d.GetElementAt(
                                    w))
                            *
                            (double)n.GetElementAtAsint(
                                sIndexElement)
                            *
                            ((double)Math.Floor(
                                (decimal)w
                                /
                                i.Getl())
                            +
                            1);
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