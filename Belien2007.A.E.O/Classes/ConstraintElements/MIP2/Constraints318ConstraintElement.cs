namespace Belien2007.A.E.O.Classes.ConstraintElements.MIP2
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Belien2007.A.E.O.Interfaces.ConstraintElements.MIP2;
    using Belien2007.A.E.O.Interfaces.CrossJoins.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.ActivePeriods;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonDayLengthOfStayProbabilities;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonLengthOfStayMaximums;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonMaximumNumberPatients;
    using Belien2007.A.E.O.Interfaces.Variables.Common;

    internal sealed class Constraints318ConstraintElement : IConstraints318ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints318ConstraintElement(
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

            ImmutableList<Expression>.Builder builder = ImmutableList.CreateBuilder<Expression>();

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

                    for (int w = dLowerBound;
                        w <= m.GetElementAtAsint(sIndexElement);
                        w = w + 1)
                    {
                        builder.Add(
                            (double)n.GetElementAtAsint(
                                sIndexElement)
                            *
                            (double)p.GetElementAtAsdecimal(
                                sIndexElement,
                                d.GetElementAt(
                                    w))
                            *
                            (double)Math.Ceiling(
                                (decimal)w
                                /
                                i.Getl())
                            *
                            x.Value[
                                i.GetElementAt(
                                    jIndexElement.Key),
                                sIndexElement]);
                    }
                }
            }

            Expression RHS = Expression.Sum(
                builder.ToImmutableList());

            this.Value = LHS == RHS;
        }

        public Constraint Value { get; }
    }
}