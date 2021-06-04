namespace Belien2007.A.E.O.Factories.ParameterElements.Common.ActivePeriods
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Classes.ParameterElements.Common.ActivePeriods;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.ActivePeriods;
    using Belien2007.A.E.O.InterfacesFactories.ParameterElements.Common.ActivePeriods;

    internal sealed class AParameterElementFactory : IAParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public AParameterElementFactory()
        {
        }

        public IAParameterElement Create(
            IiIndexElement iIndexElement,
            FhirBoolean value)
        {
            IAParameterElement parameterElement = null;

            try
            {
                parameterElement = new AParameterElement(
                    iIndexElement,
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