namespace Belien2007.A.E.O.Interfaces.Contexts.MIP2
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    public interface IMIP2InputContext
    {
        ImmutableSortedSet<INullableValue<int>> LengthOfStayDays { get; }

        ImmutableList<KeyValuePair<INullableValue<int>, FhirDateTime>> PlanningHorizon { get; }

        Bundle Surgeons { get; }

        ImmutableList<KeyValuePair<FhirDateTime, INullableValue<bool>>> ActivePeriods { get; }

        RedBlackTree<FhirDateTime, INullableValue<int>> DayNumberTimeBlocks { get; }

        ImmutableList<KeyValuePair<FhirDateTime, INullableValue<int>>> DayBedCapacities { get; }

        ImmutableList<KeyValuePair<Organization, INullableValue<int>>> SurgeonLengthOfStayMaximums { get; }

        RedBlackTree<Organization, INullableValue<int>> SurgeonMaximumNumberPatients { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<decimal>>> SurgeonDayLengthOfStayProbabilities { get; }

        RedBlackTree<Organization, INullableValue<int>> SurgeonNumberTimeBlocks { get; }

        INullableValue<decimal> MeanWeight { get; }

        INullableValue<decimal> VarianceWeight { get; }
    }
}