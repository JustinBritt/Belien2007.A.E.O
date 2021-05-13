namespace Belien2007.A.E.O.Classes.Contexts.MIP2
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.Contexts.MIP2;

    public sealed class MIP2InputContext : IMIP2InputContext
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public MIP2InputContext(
            ImmutableList<PositiveInt> lengthOfStayDays,
            ImmutableList<KeyValuePair<PositiveInt, FhirDateTime>> planningHorizon,
            Bundle surgeons,
            ImmutableList<KeyValuePair<FhirDateTime, FhirBoolean>> activePeriods,
            ImmutableList<KeyValuePair<FhirDateTime, PositiveInt>> dayNumberTimeBlocks,
            ImmutableList<KeyValuePair<FhirDateTime, PositiveInt>> dayBedCapacities,
            ImmutableList<KeyValuePair<Organization, PositiveInt>> surgeonLengthOfStayMaximums,
            ImmutableList<KeyValuePair<Organization, PositiveInt>> surgeonMaximumNumberPatients,
            ImmutableList<Tuple<Organization, PositiveInt, FhirDecimal>> surgeonDayLengthOfStayProbabilities,
            ImmutableList<KeyValuePair<Organization, PositiveInt>> surgeonNumberTimeBlocks,
            FhirDecimal meanWeight,
            FhirDecimal varianceWeight)
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

        public ImmutableList<PositiveInt> LengthOfStayDays { get; }

        public ImmutableList<KeyValuePair<PositiveInt, FhirDateTime>> PlanningHorizon { get; }

        public Bundle Surgeons { get; }

        public ImmutableList<KeyValuePair<FhirDateTime, FhirBoolean>> ActivePeriods { get; }

        public ImmutableList<KeyValuePair<FhirDateTime, PositiveInt>> DayNumberTimeBlocks { get; }

        public ImmutableList<KeyValuePair<FhirDateTime, PositiveInt>> DayBedCapacities { get; }

        public ImmutableList<KeyValuePair<Organization, PositiveInt>> SurgeonLengthOfStayMaximums { get; }

        public ImmutableList<KeyValuePair<Organization, PositiveInt>> SurgeonMaximumNumberPatients { get; }

        public ImmutableList<Tuple<Organization, PositiveInt, FhirDecimal>> SurgeonDayLengthOfStayProbabilities { get; }

        public ImmutableList<KeyValuePair<Organization, PositiveInt>> SurgeonNumberTimeBlocks { get; }

        public FhirDecimal MeanWeight { get; }

        public FhirDecimal VarianceWeight { get; }
    }
}