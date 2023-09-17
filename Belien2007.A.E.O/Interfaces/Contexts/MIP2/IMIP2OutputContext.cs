namespace Belien2007.A.E.O.Interfaces.Contexts.MIP2
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    public interface IMIP2OutputContext
    {
        INullableValue<decimal> BestBound { get; }

        RedBlackTree<FhirDateTime, INullableValue<decimal>> DayExpectedBedShortages { get; }

        INullableValue<decimal> Gap { get; }

        long NumberOfExploredNodes { get; }

        INullableValue<decimal> ObjectiveValue { get; }

        TimeSpan OverallWallTime { get; }

        RedBlackTree<Organization, INullableValue<int>> SurgeonNumberAssignedDays { get; }

        INullableValue<decimal> TotalExpectedBedShortage { get; }

        ImmutableList<Tuple<FhirDateTime, Organization, INullableValue<int>>> DaySurgeonNumberBlockAssignments { get; }

        INullableValue<decimal> BedOccupancyMaximalWeightedSum { get; }

        RedBlackTree<FhirDateTime, INullableValue<decimal>> DayBedOccupancyMeans { get; }

        ImmutableList<Tuple<FhirDateTime, INullableValue<decimal>>> DayBedOccupancyVariances { get; }
    }
}