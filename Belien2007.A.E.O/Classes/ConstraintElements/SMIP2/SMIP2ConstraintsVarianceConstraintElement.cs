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
    using Belien2007.A.E.O.Interfaces.Parameters.Stochastic.SurgeonNumberStates;
    using Belien2007.A.E.O.Interfaces.Parameters.Stochastic.SurgeonStateMaximumNumberPatients;
    using Belien2007.A.E.O.Interfaces.Parameters.Stochastic.SurgeonStateProbabilities;
    using Belien2007.A.E.O.Interfaces.Variables.Common;

    internal sealed class SMIP2ConstraintsVarianceConstraintElement : ISMIP2ConstraintsVarianceConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SMIP2ConstraintsVarianceConstraintElement(
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
            Iq q,
            Ix x,
            IVariance Variance)
        {
            Expression LHS = Variance.Value[iIndexElement];

            ImmutableList<Tuple<IsIndexElement, IjIndexElement, double>>.Builder sj_Builder = ImmutableList.CreateBuilder<Tuple<IsIndexElement, IjIndexElement, double>>();

            ImmutableList<Tuple<IsIndexElement, IjIndexElement, IkIndexElement, double>>.Builder sjk_Builder = ImmutableList.CreateBuilder<Tuple<IsIndexElement, IjIndexElement, IkIndexElement, double>>();

            ImmutableList<Tuple<IsIndexElement, IjIndexElement, IkIndexElement, double>>.Builder sjk_EV_Builder = ImmutableList.CreateBuilder<Tuple<IsIndexElement, IjIndexElement, IkIndexElement, double>>();

            ImmutableList<Tuple<IsIndexElement, IjIndexElement, IkIndexElement, double>>.Builder sjk_VE_Builder = ImmutableList.CreateBuilder<Tuple<IsIndexElement, IjIndexElement, IkIndexElement, double>>();

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

                    double RHS_Sum_EV = 0;

                    // E[V[U(i, j, s) | N(s)]]
                    foreach (IkIndexElement kIndexElement in k.Value.Values)
                    {
                        for (int w = dLowerBound;
                            w <= m.GetElementAtAsint(sIndexElement);
                            w = w + 1)
                        {
                            RHS_Sum_EV +=
                                (double)p.GetElementAtAsdecimal(
                                    sIndexElement,
                                    d.GetElementAt(
                                        w))
                                *
                                (double)(1 
                                -
                                p.GetElementAtAsdecimal(
                                    sIndexElement,
                                    d.GetElementAt(
                                        w)))
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

                        for (int y = dLowerBound;
                        y <= m.GetElementAtAsint(sIndexElement);
                        y = y + 1)
                        {
                            for (int z = dLowerBound;
                            z <= y - 1;
                            z = z + 1)
                            {
                                RHS_Sum_EV -=
                                    (double)2
                                    *
                                    (double)p.GetElementAtAsdecimal(
                                        sIndexElement,
                                        d.GetElementAt(
                                            y))
                                    *
                                    (double)p.GetElementAtAsdecimal(
                                        sIndexElement,
                                        d.GetElementAt(
                                            z))
                                    *
                                    (double)n.GetElementAtAsint(
                                        sIndexElement,
                                        kIndexElement)
                                    *
                                    (double)Math.Ceiling(
                                        (decimal)z
                                        /
                                        i.Getl());
                            }
                        }

                        sjk_EV_Builder.Add(
                            Tuple.Create(
                                sIndexElement,
                                jIndexElement,
                                kIndexElement,
                                (double)h.GetElementAtAsdecimal(
                                    sIndexElement,
                                    kIndexElement) 
                                *
                                RHS_Sum_EV));
                    }

                    double RHS_Sum_VE = 0;

                    // V[E[U(i, j, s) | N(s)]]
                    foreach (IkIndexElement kIndexElement in k.Value.Values)
                    {
                        for (int w = dLowerBound;
                            w <= m.GetElementAtAsint(sIndexElement);
                            w = w + 1)
                        {
                            RHS_Sum_VE +=
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

                        foreach (IkIndexElement kIndexElementPrime in k.Value.Values)
                        {
                            for (int w = dLowerBound;
                                w <= m.GetElementAtAsint(sIndexElement);
                                w = w + 1)
                            {
                                RHS_Sum_VE -=
                                    (double)h.GetElementAtAsdecimal(
                                        sIndexElement,
                                        kIndexElementPrime)
                                    *
                                    (double)p.GetElementAtAsdecimal(
                                        sIndexElement,
                                        d.GetElementAt(
                                            w))
                                    *
                                    (double)n.GetElementAtAsint(
                                        sIndexElement,
                                        k.GetElementAt(
                                            q.GetElementAtAsint(
                                                sIndexElement)))
                                    *
                                    (double)Math.Ceiling(
                                        (decimal)w
                                        /
                                        i.Getl());
                            }
                        }

                        sjk_VE_Builder.Add(
                           Tuple.Create(
                                sIndexElement,
                                jIndexElement,
                                kIndexElement,
                                (double)h.GetElementAtAsdecimal(
                                    sIndexElement,
                                    kIndexElement)
                                *
                                Math.Pow(
                                    RHS_Sum_VE,
                                    2)));
                    }

                    ImmutableList<Tuple<IsIndexElement, IjIndexElement, IkIndexElement, double>> RHS_Sums_sjk_EV = sjk_EV_Builder.ToImmutableList();

                    ImmutableList<Tuple<IsIndexElement, IjIndexElement, IkIndexElement, double>> RHS_Sums_sjk_VE = sjk_VE_Builder.ToImmutableList();

                    foreach (IkIndexElement kIndexElement in k.Value.Values)
                    {
                        double RHS_Sum_sjk = 
                            RHS_Sums_sjk_EV
                            .Where(w => w.Item1 == sIndexElement && w.Item2 == jIndexElement && w.Item3 == kIndexElement)
                            .Select(w => w.Item4)
                            .SingleOrDefault()
                            +
                            RHS_Sums_sjk_VE
                            .Where(w => w.Item1 == sIndexElement && w.Item2 == jIndexElement && w.Item3 == kIndexElement)
                            .Select(w => w.Item4)
                            .SingleOrDefault();

                        sjk_Builder.Add(
                            Tuple.Create(
                                sIndexElement,
                                jIndexElement,
                                kIndexElement,
                                RHS_Sum_sjk));
                    }

                    ImmutableList<Tuple<IsIndexElement, IjIndexElement, IkIndexElement, double>> RHS_Sums_sjk = sjk_Builder.ToImmutableList();

                    double RHS_Sum = 0;

                    foreach (IkIndexElement kIndexElement in k.Value.Values)
                    {
                        RHS_Sum +=
                            RHS_Sums_sjk
                            .Where(w => w.Item1 == sIndexElement && w.Item2 == jIndexElement && w.Item3 == kIndexElement)
                            .Select(w => w.Item4)
                            .SingleOrDefault();
                    }

                    sj_Builder.Add(
                        Tuple.Create(
                            sIndexElement,
                            jIndexElement,
                            RHS_Sum));
                }
            }

            ImmutableList<Tuple<IsIndexElement, IjIndexElement, double>> RHS_Sums = sj_Builder.ToImmutableList();

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