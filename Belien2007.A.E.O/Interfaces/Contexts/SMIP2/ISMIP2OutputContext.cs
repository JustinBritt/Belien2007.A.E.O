namespace Belien2007.A.E.O.Interfaces.Contexts.SMIP2
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    public interface ISMIP2OutputContext
    {
        INullableValue<decimal> BestBound { get; }

        RedBlackTree<FhirDateTime, INullableValue<decimal>> DayExpectedBedShortages { get; }

        INullableValue<decimal> Gap { get; }

        long NumberOfExploredNodes { get; }

        INullableValue<decimal> ObjectiveValue { get; }

        TimeSpan OverallWallTime { get; }

        RedBlackTree<INullableValue<int>, INullableValue<int>> StateNumberPatients { get; }

        RedBlackTree<Organization, INullableValue<int>> SurgeonNumberAssignedDays { get; }

        RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>> SurgeonStateNumberPatients { get; }

        INullableValue<decimal> TotalExpectedBedShortage { get; }

        RedBlackTree<FhirDateTime, RedBlackTree<Organization, INullableValue<int>>> DaySurgeonNumberBlockAssignments { get; }

        INullableValue<decimal> BedOccupancyMaximalWeightedSum { get; }

        RedBlackTree<FhirDateTime, INullableValue<decimal>> DayBedOccupancyMeans { get; }

        RedBlackTree<FhirDateTime, INullableValue<decimal>> DayBedOccupancyVariances { get; }
    }
}