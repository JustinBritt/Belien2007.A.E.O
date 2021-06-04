namespace Belien2007.A.E.O.Factories.ParameterElements.Common.SurgeonDayLengthOfStayProbabilities
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Classes.ParameterElements.Common.SurgeonDayLengthOfStayProbabilities;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.SurgeonDayLengthOfStayProbabilities;
    using Belien2007.A.E.O.InterfacesFactories.ParameterElements.Common.SurgeonDayLengthOfStayProbabilities;

    internal sealed class pParameterElementFactory : IpParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public pParameterElementFactory()
        {
        }

        public IpParameterElement Create(
            IsIndexElement sIndexElement,
            IdIndexElement dIndexElement,
            FhirDecimal value)
        {
            IpParameterElement parameterElement = null;

            try
            {
                parameterElement = new pParameterElement(
                    sIndexElement,
                    dIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameterElement;
        }
    }
}