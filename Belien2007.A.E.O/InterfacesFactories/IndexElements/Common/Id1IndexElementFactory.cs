namespace Belien2007.A.E.O.InterfacesFactories.IndexElements.Common
{
    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;

    public interface Id1IndexElementFactory
    {
        Id1IndexElement Create(
            INullableValue<int> value);
    }
}