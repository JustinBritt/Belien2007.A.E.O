﻿namespace Belien2007.A.E.O.Classes.Contexts.MIP2
{
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.Contexts.MIP2;

    public sealed class MIP2InputContext : IMIP2InputContext
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public MIP2InputContext(
            ImmutableSortedSet<INullableValue<int>> lengthOfStayDays,
            RedBlackTree<INullableValue<int>, FhirDateTime> planningHorizon,
            Bundle surgeons,
            RedBlackTree<FhirDateTime, INullableValue<bool>> activePeriods,
            RedBlackTree<FhirDateTime, INullableValue<int>> dayNumberTimeBlocks,
            RedBlackTree<FhirDateTime, INullableValue<int>> dayBedCapacities,
            RedBlackTree<Organization, INullableValue<int>> surgeonLengthOfStayMaximums,
            RedBlackTree<Organization, INullableValue<int>> surgeonMaximumNumberPatients,
            RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> surgeonDayLengthOfStayProbabilities,
            RedBlackTree<Organization, INullableValue<int>> surgeonNumberTimeBlocks,
            INullableValue<decimal> meanWeight,
            INullableValue<decimal> varianceWeight)
        {
            this.LengthOfStayDays = lengthOfStayDays;

            this.PlanningHorizon = planningHorizon;

            this.Surgeons = surgeons;

            this.ActivePeriods = activePeriods;

            this.DayNumberTimeBlocks = dayNumberTimeBlocks;

            this.DayBedCapacities = dayBedCapacities;

            this.SurgeonLengthOfStayMaximums = surgeonLengthOfStayMaximums;

            this.SurgeonMaximumNumberPatients = surgeonMaximumNumberPatients;

            this.SurgeonDayLengthOfStayProbabilities = surgeonDayLengthOfStayProbabilities;

            this.SurgeonNumberTimeBlocks = surgeonNumberTimeBlocks;

            this.MeanWeight = meanWeight;

            this.VarianceWeight = varianceWeight;
        }

        public ImmutableSortedSet<INullableValue<int>> LengthOfStayDays { get; }

        public RedBlackTree<INullableValue<int>, FhirDateTime> PlanningHorizon { get; }

        public Bundle Surgeons { get; }

        public RedBlackTree<FhirDateTime, INullableValue<bool>> ActivePeriods { get; }

        public RedBlackTree<FhirDateTime, INullableValue<int>> DayNumberTimeBlocks { get; }

        public RedBlackTree<FhirDateTime, INullableValue<int>> DayBedCapacities { get; }

        public RedBlackTree<Organization, INullableValue<int>> SurgeonLengthOfStayMaximums { get; }

        public RedBlackTree<Organization, INullableValue<int>> SurgeonMaximumNumberPatients { get; }

        public RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> SurgeonDayLengthOfStayProbabilities { get; }

        public RedBlackTree<Organization, INullableValue<int>> SurgeonNumberTimeBlocks { get; }

        public INullableValue<decimal> MeanWeight { get; }

        public INullableValue<decimal> VarianceWeight { get; }
    }
}