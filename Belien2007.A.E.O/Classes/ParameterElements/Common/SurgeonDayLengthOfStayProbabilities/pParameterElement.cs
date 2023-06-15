namespace Belien2007.A.E.O.Classes.ParameterElements.Common.SurgeonDayLengthOfStayProbabilities
{
    using log4net;

    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.SurgeonDayLengthOfStayProbabilities;

    internal sealed class pParameterElement : IpParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public pParameterElement(
            IsIndexElement sIndexElement,
            IdIndexElement dIndexElement,
            INullableValue<decimal> value)
        {
            this.sIndexElement = sIndexElement;

            this.dIndexElement = dIndexElement;

            this.Value = value;
        }

        public IsIndexElement sIndexElement { get; }

        public IdIndexElement dIndexElement { get; }

        public INullableValue<decimal> Value { get; }
    }
}