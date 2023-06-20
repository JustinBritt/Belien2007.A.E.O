namespace Belien2007.A.E.O.Interfaces.Indices.Stochastic
{
    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;

    public interface Ik
    {
        RedBlackTree<INullableValue<int>, IkIndexElement> Value { get; }

        IkIndexElement GetElementAt(
            int value);

        IkIndexElement GetElementAt(
            INullableValue<int> value);
    }
}