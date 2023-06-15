namespace Belien2007.A.E.O.Factories.ParameterElements.Common.DayNumberAvailableTimeBlocks
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Classes.ParameterElements.Common.DayNumberAvailableTimeBlocks;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.DayNumberAvailableTimeBlocks;
    using Belien2007.A.E.O.InterfacesFactories.ParameterElements.Common.DayNumberAvailableTimeBlocks;

    internal sealed class bParameterElementFactory : IbParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public bParameterElementFactory()
        {
        }

        public IbParameterElement Create(
            IiIndexElement iIndexElement,
            INullableValue<int> value)
        {
            IbParameterElement parameterElement = null;

            try
            {
                parameterElement = new bParameterElement(
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