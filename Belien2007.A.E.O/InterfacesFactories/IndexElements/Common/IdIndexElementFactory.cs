namespace Belien2007.A.E.O.InterfacesFactories.IndexElements.Common
{
    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;

    public interface IdIndexElementFactory
    {
        IdIndexElement Create(
            INullableValue<int> value);
    }
}