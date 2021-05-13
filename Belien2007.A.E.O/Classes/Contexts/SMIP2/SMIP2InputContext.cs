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
            ImmutableList<PositiveInt> lengthOfStayDays,
            ImmutableList<KeyValuePair<PositiveInt, FhirDateTime>> planningHorizon,
            ImmutableList<PositiveInt> states,
            Bundle surgeons,
            ImmutableList<KeyValuePair<FhirDateTime, FhirBoolean>> activePeriods,
            ImmutableList<KeyValuePair<FhirDateTime, PositiveInt>> dayNumberTimeBlocks,
            ImmutableList<KeyValuePair<FhirDateTime, PositiveInt>> dayBedCapacities,
            ImmutableList<Tuple<Organization, PositiveInt, FhirDecimal>> surgeonStateProbabilities,
            ImmutableList<KeyValuePair<Organization, PositiveInt>> surgeonLengthOfStayMaximums,
            ImmutableList<Tuple<Organization, PositiveInt, PositiveInt>> surgeonStateMaximumNumberPatients,
            ImmutableList<Tuple<Organization, PositiveInt, FhirDecimal>> surgeonDayLengthOfStayProbabilities,
            ImmutableList<KeyValuePair<Organization, PositiveInt>> surgeonNumberStates,
            ImmutableList<KeyValuePair<Organization, PositiveInt>> surgeonNumberTimeBlocks,
            FhirDecimal meanWeight,
            FhirDecimal varianceWeight)
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

        public ImmutableList<PositiveInt> LengthOfStayDays { get; }

        public ImmutableList<KeyValuePair<PositiveInt, FhirDateTime>> PlanningHorizon { get; }

        public ImmutableList<PositiveInt> States { get; }

        public Bundle Surgeons { get; }

        public ImmutableList<KeyValuePair<FhirDateTime, FhirBoolean>> ActivePeriods { get; }

        public ImmutableList<KeyValuePair<FhirDateTime, PositiveInt>> DayNumberTimeBlocks { get; }

        public ImmutableList<KeyValuePair<FhirDateTime, PositiveInt>> DayBedCapacities { get; }

        public ImmutableList<Tuple<Organization, PositiveInt, FhirDecimal>> SurgeonStateProbabilities { get; }

        public ImmutableList<KeyValuePair<Organization, PositiveInt>> SurgeonLengthOfStayMaximums { get; }

        public ImmutableList<Tuple<Organization, PositiveInt, PositiveInt>> SurgeonStateMaximumNumberPatients { get; }

        public ImmutableList<Tuple<Organization, PositiveInt, FhirDecimal>> SurgeonDayLengthOfStayProbabilities { get; }

        public ImmutableList<KeyValuePair<Organization, PositiveInt>> SurgeonNumberStates { get; }

        public ImmutableList<KeyValuePair<Organization, PositiveInt>> SurgeonNumberTimeBlocks { get; }

        public FhirDecimal MeanWeight { get; }

        public FhirDecimal VarianceWeight { get; }
    }
}