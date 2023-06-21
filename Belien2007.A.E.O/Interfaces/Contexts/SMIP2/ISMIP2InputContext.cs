namespace Belien2007.A.E.O.Interfaces.Contexts.SMIP2
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    public interface ISMIP2InputContext
    {
        ImmutableSortedSet<INullableValue<int>> LengthOfStayDays { get; }

        RedBlackTree<INullableValue<int>, FhirDateTime> PlanningHorizon { get; }

        ImmutableSortedSet<INullableValue<int>> States { get; }

        Bundle Surgeons { get; }

        ImmutableList<KeyValuePair<FhirDateTime, INullableValue<bool>>> ActivePeriods { get; }

        RedBlackTree<FhirDateTime, INullableValue<int>> DayNumberTimeBlocks { get; }

        RedBlackTree<FhirDateTime, INullableValue<int>> DayBedCapacities { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<decimal>>> SurgeonStateProbabilities { get; }

        RedBlackTree<Organization, INullableValue<int>> SurgeonLengthOfStayMaximums { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>>> SurgeonStateMaximumNumberPatients { get; }

        RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> SurgeonDayLengthOfStayProbabilities { get; }

        ImmutableList<KeyValuePair<Organization, INullableValue<int>>> SurgeonNumberStates { get; }

        ImmutableList<KeyValuePair<Organization, INullableValue<int>>> SurgeonNumberTimeBlocks { get; }

        INullableValue<decimal> MeanWeight { get; }

        INullableValue<decimal> VarianceWeight { get; }
    }
}