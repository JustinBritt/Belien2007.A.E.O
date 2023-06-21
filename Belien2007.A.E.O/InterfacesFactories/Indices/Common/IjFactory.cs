namespace Belien2007.A.E.O.InterfacesFactories.Indices.Common
{
    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Common;

    public interface IjFactory
    {
        Ij Create(
           RedBlackTree<FhirDateTime, IjIndexElement> value);
    }
}