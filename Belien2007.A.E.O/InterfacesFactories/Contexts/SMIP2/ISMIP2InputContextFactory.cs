namespace Belien2007.A.E.O.InterfacesFactories.Contexts.SMIP2
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.Contexts.SMIP2;
    using NGenerics.DataStructures.Trees;

    public interface ISMIP2InputContextFactory
    {
        ISMIP2InputContext Create(
            ImmutableSortedSet<INullableValue<int>> lengthOfStayDays,
            RedBlackTree<INullableValue<int>, FhirDateTime> planningHorizon,
            ImmutableSortedSet<INullableValue<int>> states,
            Bundle surgeons,
            RedBlackTree<FhirDateTime, INullableValue<bool>> activePeriods,
            RedBlackTree<FhirDateTime, INullableValue<int>> dayNumberTimeBlocks,
            RedBlackTree<FhirDateTime, INullableValue<int>> dayBedCapacities,
            RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> surgeonStateProbabilities,
            RedBlackTree<Organization, INullableValue<int>> surgeonLengthOfStayMaximums,
            ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>>> surgeonStateMaximumNumberPatients,
            RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> surgeonDayLengthOfStayProbabilities,
            RedBlackTree<Organization, INullableValue<int>> surgeonNumberStates,
            RedBlackTree<Organization, INullableValue<int>> surgeonNumberTimeBlocks,
            INullableValue<decimal> meanWeight,
            INullableValue<decimal> varianceWeight);
    }
}