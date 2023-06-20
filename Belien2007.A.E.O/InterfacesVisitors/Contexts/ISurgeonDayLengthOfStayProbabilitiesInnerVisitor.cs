namespace Belien2007.A.E.O.InterfacesVisitors.Contexts
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.SurgeonDayLengthOfStayProbabilities;
    using NGenerics.Patterns.Visitor;

    public interface ISurgeonDayLengthOfStayProbabilitiesInnerVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : INullableValue<int>
        where TValue : INullableValue<decimal>
    {
        RedBlackTree<IdIndexElement, IpParameterElement> RedBlackTree { get; }
    }
}