namespace Belien2007.A.E.O.Interfaces.Indices.Common
{
    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;

    public interface Id2
    {
        RedBlackTree<INullableValue<int>, Id2IndexElement> Value { get; }
    }
}