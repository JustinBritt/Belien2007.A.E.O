namespace Belien2007.A.E.O.InterfacesFactories.ParameterElements.Common.ActivePeriods
{
    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.ActivePeriods;

    public interface IAParameterElementFactory
    {
        IAParameterElement Create(
            IiIndexElement iIndexElement,
            FhirBoolean value);
    }
}