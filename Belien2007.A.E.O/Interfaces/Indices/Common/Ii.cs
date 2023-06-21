namespace Belien2007.A.E.O.Interfaces.Indices.Common
{
    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;

    public interface Ii
    {
        RedBlackTree<FhirDateTime, IiIndexElement> Value { get; }

        IiIndexElement GetElementAt(
            int value);

        IiIndexElement GetElementAt(
            FhirDateTime value);

        int Getl();
    }
}