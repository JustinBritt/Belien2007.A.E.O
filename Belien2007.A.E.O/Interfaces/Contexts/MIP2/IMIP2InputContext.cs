namespace Belien2007.A.E.O.Interfaces.Contexts.MIP2
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    public interface IMIP2InputContext
    {
        ImmutableList<PositiveInt> LengthOfStayDays { get; }

        ImmutableList<KeyValuePair<PositiveInt, FhirDateTime>> PlanningHorizon { get; }

        Bundle Surgeons { get; }

        ImmutableList<KeyValuePair<FhirDateTime, FhirBoolean>> ActivePeriods { get; }

        ImmutableList<KeyValuePair<FhirDateTime, PositiveInt>> DayNumberTimeBlocks { get; }

        ImmutableList<KeyValuePair<FhirDateTime, PositiveInt>> DayBedCapacities { get; }

        ImmutableList<KeyValuePair<Organization, PositiveInt>> SurgeonLengthOfStayMaximums { get; }

        ImmutableList<KeyValuePair<Organization, PositiveInt>> SurgeonMaximumNumberPatients { get; }

        ImmutableList<Tuple<Organization, PositiveInt, FhirDecimal>> SurgeonDayLengthOfStayProbabilities { get; }

        ImmutableList<KeyValuePair<Organization, PositiveInt>> SurgeonNumberTimeBlocks { get; }

        FhirDecimal MeanWeight { get; }

        FhirDecimal VarianceWeight { get; }
    }
}