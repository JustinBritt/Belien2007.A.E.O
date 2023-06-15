namespace Belien2007.A.E.O.InterfacesFactories.ParameterElements.Common.DayNumberAvailableTimeBlocks
{
    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.DayNumberAvailableTimeBlocks;

    public interface IbParameterElementFactory
    {
        IbParameterElement Create(
            IiIndexElement iIndexElement,
            INullableValue<int> value);
    }
}