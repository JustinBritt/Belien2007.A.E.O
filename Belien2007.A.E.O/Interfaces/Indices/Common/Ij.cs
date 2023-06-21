namespace Belien2007.A.E.O.Interfaces.Indices.Common
{
    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;

    public interface Ij
    {
        RedBlackTree<FhirDateTime, IjIndexElement> Value { get; }

        IjIndexElement GetElementAt(
            FhirDateTime value);
    }
}