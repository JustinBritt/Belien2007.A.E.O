namespace Belien2007.A.E.O.InterfacesVisitors.Contexts.Common
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.SurgeonNumberTimeBlocks;

    public interface ISurgeonNumberTimeBlocksVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : Organization
        where TValue : INullableValue<int>
    {
        RedBlackTree<IsIndexElement, IrParameterElement> RedBlackTree { get; }
    }
}