namespace Belien2007.A.E.O.Classes.ParameterElements.Common.SurgeonLengthOfStayMaximums
{
    using log4net;

    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.SurgeonLengthOfStayMaximums;

    internal sealed class mParameterElement : ImParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public mParameterElement(
            IsIndexElement sIndexElement,
            PositiveInt value)
        {
            this.sIndexElement = sIndexElement;

            this.Value = value;
        }

        public IsIndexElement sIndexElement { get; }

        public PositiveInt Value { get; }
    }
}