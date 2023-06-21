namespace Belien2007.A.E.O.Classes.Contexts.SMIP2
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.Contexts.SMIP2;

    public sealed class SMIP2InputContext : ISMIP2InputContext
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SMIP2InputContext(
            ImmutableSortedSet<INullableValue<int>> lengthOfStayDays,
            RedBlackTree<INullableValue<int>, FhirDateTime> planningHorizon,
            ImmutableSortedSet<INullableValue<int>> states,
            Bundle surgeons,
            RedBlackTree<FhirDateTime, INullableValue<bool>> activePeriods,
            RedBlackTree<FhirDateTime, INullableValue<int>> dayNumberTimeBlocks,
            RedBlackTree<FhirDateTime, INullableValue<int>> dayBedCapacities,
            ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<decimal>>> surgeonStateProbabilities,
            RedBlackTree<Organization, INullableValue<int>> surgeonLengthOfStayMaximums,
            ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>>> surgeonStateMaximumNumberPatients,
            RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> surgeonDayLengthOfStayProbabilities,
            RedBlackTree<Organization, INullableValue<int>> surgeonNumberStates,
            RedBlackTree<Organization, INullableValue<int>> surgeonNumberTimeBlocks,
            INullableValue<decimal> meanWeight,
            INullableValue<decimal> varianceWeight)
        {
            this.LengthOfStayDays = lengthOfStayDays;

            this.PlanningHorizon = planningHorizon;

            this.States = states;

            this.Surgeons = surgeons;

            this.ActivePeriods = activePeriods;

            this.DayNumberTimeBlocks = dayNumberTimeBlocks;

            this.DayBedCapacities = dayBedCapacities;

            this.SurgeonStateProbabilities = surgeonStateProbabilities;

            this.SurgeonLengthOfStayMaximums = surgeonLengthOfStayMaximums;

            this.SurgeonStateMaximumNumberPatients = surgeonStateMaximumNumberPatients;

            this.SurgeonDayLengthOfStayProbabilities = surgeonDayLengthOfStayProbabilities;

            this.SurgeonNumberTimeBlocks = surgeonNumberTimeBlocks;

            this.SurgeonNumberStates = surgeonNumberStates;

            this.MeanWeight = meanWeight;

            this.VarianceWeight = varianceWeight;
        }

        public ImmutableSortedSet<INullableValue<int>> LengthOfStayDays { get; }

        public RedBlackTree<INullableValue<int>, FhirDateTime> PlanningHorizon { get; }

        public ImmutableSortedSet<INullableValue<int>> States { get; }

        public Bundle Surgeons { get; }

        public RedBlackTree<FhirDateTime, INullableValue<bool>> ActivePeriods { get; }

        public RedBlackTree<FhirDateTime, INullableValue<int>> DayNumberTimeBlocks { get; }

        public RedBlackTree<FhirDateTime, INullableValue<int>> DayBedCapacities { get; }

        public ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<decimal>>> SurgeonStateProbabilities { get; }

        public RedBlackTree<Organization, INullableValue<int>> SurgeonLengthOfStayMaximums { get; }

        public ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>>> SurgeonStateMaximumNumberPatients { get; }

        public RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> SurgeonDayLengthOfStayProbabilities { get; }

        public RedBlackTree<Organization, INullableValue<int>> SurgeonNumberStates { get; }

        public RedBlackTree<Organization, INullableValue<int>> SurgeonNumberTimeBlocks { get; }

        public INullableValue<decimal> MeanWeight { get; }

        public INullableValue<decimal> VarianceWeight { get; }
    }
}