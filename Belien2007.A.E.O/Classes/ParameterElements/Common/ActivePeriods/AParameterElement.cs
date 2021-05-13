namespace Belien2007.A.E.O.Classes.ParameterElements.Common.ActivePeriods
{
    using log4net;

    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.ActivePeriods;

    internal sealed class AParameterElement : IAParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public AParameterElement(
            IiIndexElement iIndexElement,
            FhirBoolean value)
        {
            this.iIndexElement = iIndexElement;

            this.Value = value;
        }

        public IiIndexElement iIndexElement { get; }

        public FhirBoolean Value { get; }
    }
}