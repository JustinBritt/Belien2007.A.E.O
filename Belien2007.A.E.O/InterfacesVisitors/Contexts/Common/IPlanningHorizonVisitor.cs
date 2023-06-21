namespace Belien2007.A.E.O.InterfacesVisitors.Contexts.Common
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;

    public interface IPlanningHorizonVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : INullableValue<int>
        where TValue : FhirDateTime
    {
        RedBlackTree<FhirDateTime, IiIndexElement> iRedBlackTree { get; }

        RedBlackTree<FhirDateTime, IjIndexElement> jRedBlackTree { get; }
    }
}