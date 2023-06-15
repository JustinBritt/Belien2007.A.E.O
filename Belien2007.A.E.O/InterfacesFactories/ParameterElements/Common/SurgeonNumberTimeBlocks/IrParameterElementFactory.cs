namespace Belien2007.A.E.O.InterfacesFactories.ParameterElements.Common.SurgeonNumberTimeBlocks
{
    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.SurgeonNumberTimeBlocks;

    public interface IrParameterElementFactory
    {
        IrParameterElement Create(
            IsIndexElement sIndexElement,
            INullableValue<int> value);
    }
}