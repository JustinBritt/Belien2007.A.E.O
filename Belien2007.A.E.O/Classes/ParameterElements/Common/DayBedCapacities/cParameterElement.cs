namespace Belien2007.A.E.O.Classes.ParameterElements.Common.DayBedCapacities
{
    using log4net;

    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.DayBedCapacities;

    internal sealed class cParameterElement : IcParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public cParameterElement(
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