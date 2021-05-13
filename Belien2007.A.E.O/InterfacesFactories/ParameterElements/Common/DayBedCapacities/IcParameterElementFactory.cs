namespace Belien2007.A.E.O.InterfacesFactories.ParameterElements.Common.DayBedCapacities
{
    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.DayBedCapacities;

    public interface IcParameterElementFactory
    {
        IcParameterElement Create(
            IiIndexElement iIndexElement,
            PositiveInt value);
    }
}