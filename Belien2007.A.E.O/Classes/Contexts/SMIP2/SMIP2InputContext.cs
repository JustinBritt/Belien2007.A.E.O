namespace Belien2007.A.E.O.Classes.Contexts.SMIP2
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.Contexts.SMIP2;

    public sealed class SMIP2InputContext : ISMIP2InputContext
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SMIP2InputContext(
            ImmutableSortedSet<INullableValue<int>> lengthOfStayDays,
            ImmutableList<KeyValuePair<INullableValue<int>, FhirDateTime>> planningHorizon,
            ImmutableList<INullableValue<int>> states,
            Bundle surgeons,
            ImmutableList<KeyValuePair<FhirDateTime, INullableValue<bool>>> activePeriods,
            ImmutableList<KeyValuePair<FhirDateTime, INullableValue<int>>> dayNumberTimeBlocks,
            ImmutableList<KeyValuePair<FhirDateTime, INullableValue<int>>> dayBedCapacities,
            ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<decimal>>> surgeonStateProbabilities,
            ImmutableList<KeyValuePair<Organization, INullableValue<int>>> surgeonLengthOfStayMaximums,
            ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>>> surgeonStateMaximumNumberPatients,
            ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<decimal>>> surgeonDayLengthOfStayProbabilities,
            ImmutableList<KeyValuePair<Organization, INullableValue<int>>> surgeonNumberStates,
            ImmutableList<KeyValuePair<Organization, INullableValue<int>>> surgeonNumberTimeBlocks,
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

        public ImmutableList<KeyValuePair<INullableValue<int>, FhirDateTime>> PlanningHorizon { get; }

        public ImmutableList<INullableValue<int>> States { get; }

        public Bundle Surgeons { get; }

        public ImmutableList<KeyValuePair<FhirDateTime, INullableValue<bool>>> ActivePeriods { get; }

        public ImmutableList<KeyValuePair<FhirDateTime, INullableValue<int>>> DayNumberTimeBlocks { get; }

        public ImmutableList<KeyValuePair<FhirDateTime, INullableValue<int>>> DayBedCapacities { get; }

        public ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<decimal>>> SurgeonStateProbabilities { get; }

        public ImmutableList<KeyValuePair<Organization, INullableValue<int>>> SurgeonLengthOfStayMaximums { get; }

        public ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>>> SurgeonStateMaximumNumberPatients { get; }

        public ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<decimal>>> SurgeonDayLengthOfStayProbabilities { get; }

        public ImmutableList<KeyValuePair<Organization, INullableValue<int>>> SurgeonNumberStates { get; }

        public ImmutableList<KeyValuePair<Organization, INullableValue<int>>> SurgeonNumberTimeBlocks { get; }

        public INullableValue<decimal> MeanWeight { get; }

        public INullableValue<decimal> VarianceWeight { get; }
    }
}