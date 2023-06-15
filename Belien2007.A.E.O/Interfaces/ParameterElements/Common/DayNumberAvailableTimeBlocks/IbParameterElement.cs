namespace Belien2007.A.E.O.Interfaces.ParameterElements.Common.DayNumberAvailableTimeBlocks
{
    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;

    public interface IbParameterElement
    {
        IiIndexElement iIndexElement { get; }

        INullableValue<int> Value { get; }
    }
}