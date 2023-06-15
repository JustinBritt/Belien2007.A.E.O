namespace Belien2007.A.E.O.Factories.ParameterElements.Common.SurgeonLengthOfStayMaximums
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Classes.ParameterElements.Common.SurgeonLengthOfStayMaximums;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.SurgeonLengthOfStayMaximums;
    using Belien2007.A.E.O.InterfacesFactories.ParameterElements.Common.SurgeonLengthOfStayMaximums;

    internal sealed class mParameterElementFactory : ImParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public mParameterElementFactory()
        {
        }

        public ImParameterElement Create(
            IsIndexElement sIndexElement,
            INullableValue<int> value)
        {
            ImParameterElement parameterElement = null;

            try
            {
                parameterElement = new mParameterElement(
                    sIndexElement,
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