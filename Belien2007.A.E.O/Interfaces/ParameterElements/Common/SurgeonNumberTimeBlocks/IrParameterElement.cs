namespace Belien2007.A.E.O.Interfaces.ParameterElements.Common.SurgeonNumberTimeBlocks
{
    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;

    public interface IrParameterElement
    {
        IsIndexElement sIndexElement { get; }

        PositiveInt Value { get; }
    }
}