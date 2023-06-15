namespace Belien2007.A.E.O.Classes.ParameterElements.Common.DayNumberAvailableTimeBlocks
{
    using log4net;

    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.DayNumberAvailableTimeBlocks;

    internal sealed class bParameterElement : IbParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public bParameterElement(
            IiIndexElement iIndexElement,
            INullableValue<int> value)
        {
            this.iIndexElement = iIndexElement;

            this.Value = value;
        }

        public IiIndexElement iIndexElement { get; }

        public INullableValue<int> Value { get; }
    }
}