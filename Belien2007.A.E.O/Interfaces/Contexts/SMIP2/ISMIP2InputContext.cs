namespace Belien2007.A.E.O.Interfaces.Contexts.SMIP2
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    public interface ISMIP2InputContext
    {
        ImmutableList<PositiveInt> LengthOfStayDays { get; }

        ImmutableList<KeyValuePair<PositiveInt, FhirDateTime>> PlanningHorizon { get; }

        ImmutableList<PositiveInt> States { get; }

        Bundle Surgeons { get; }

        ImmutableList<KeyValuePair<FhirDateTime, FhirBoolean>> ActivePeriods { get; }

        ImmutableList<KeyValuePair<FhirDateTime, PositiveInt>> DayNumberTimeBlocks { get; }

        ImmutableList<KeyValuePair<FhirDateTime, PositiveInt>> DayBedCapacities { get; }

        ImmutableList<Tuple<Organization, PositiveInt, FhirDecimal>> SurgeonStateProbabilities { get; }

        ImmutableList<KeyValuePair<Organization, PositiveInt>> SurgeonLengthOfStayMaximums { get; }

        ImmutableList<Tuple<Organization, PositiveInt, PositiveInt>> SurgeonStateMaximumNumberPatients { get; }

        ImmutableList<Tuple<Organization, PositiveInt, FhirDecimal>> SurgeonDayLengthOfStayProbabilities { get; }

        ImmutableList<KeyValuePair<Organization, PositiveInt>> SurgeonNumberStates { get; }

        ImmutableList<KeyValuePair<Organization, PositiveInt>> SurgeonNumberTimeBlocks { get; }

        FhirDecimal MeanWeight { get; }

        FhirDecimal VarianceWeight { get; }
    }
}