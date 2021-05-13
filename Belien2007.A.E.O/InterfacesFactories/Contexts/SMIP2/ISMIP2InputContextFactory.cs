namespace Belien2007.A.E.O.InterfacesFactories.Contexts.SMIP2
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.Contexts.SMIP2;

    public interface ISMIP2InputContextFactory
    {
        ISMIP2InputContext Create(
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
            FhirDecimal varianceWeight);
    }
}