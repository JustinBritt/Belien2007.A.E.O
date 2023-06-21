namespace Belien2007.A.E.O.InterfacesVisitors.Contexts.Common
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.DayBedCapacities;

    public interface IDayBedCapacitiesVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : FhirDateTime
        where TValue : INullableValue<int>
    {
        RedBlackTree<IiIndexElement, IcParameterElement> RedBlackTree { get; }
    }
}