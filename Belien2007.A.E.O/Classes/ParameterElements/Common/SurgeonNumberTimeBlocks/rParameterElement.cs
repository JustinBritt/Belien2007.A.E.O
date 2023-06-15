namespace Belien2007.A.E.O.Classes.ParameterElements.Common.SurgeonNumberTimeBlocks
{
    using log4net;

    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.SurgeonNumberTimeBlocks;

    internal sealed class rParameterElement : IrParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public rParameterElement(
            IsIndexElement sIndexElement,
            INullableValue<int> value)
        {
            this.sIndexElement = sIndexElement;

            this.Value = value;
        }

        public IsIndexElement sIndexElement { get; }

        public INullableValue<int> Value { get; }
    }
}