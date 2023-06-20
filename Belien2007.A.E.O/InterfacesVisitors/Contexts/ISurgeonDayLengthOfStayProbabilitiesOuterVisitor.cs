namespace Belien2007.A.E.O.InterfacesVisitors.Contexts
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.SurgeonDayLengthOfStayProbabilities;

    public interface ISurgeonDayLengthOfStayProbabilitiesOuterVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : Organization
        where TValue : RedBlackTree<INullableValue<int>, INullableValue<decimal>>
    {
        RedBlackTree<IsIndexElement, RedBlackTree<IdIndexElement, IpParameterElement>> RedBlackTree { get; }
    }
}