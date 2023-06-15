namespace Belien2007.A.E.O.InterfacesFactories.IndexElements.Common
{
    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;

    public interface Id2IndexElementFactory
    {
        Id2IndexElement Create(
            INullableValue<int> value);
    }
}