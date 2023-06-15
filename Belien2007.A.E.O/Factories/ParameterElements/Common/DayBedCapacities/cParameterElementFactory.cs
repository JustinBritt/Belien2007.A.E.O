namespace Belien2007.A.E.O.Factories.ParameterElements.Common.DayBedCapacities
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Classes.ParameterElements.Common.DayBedCapacities;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.DayBedCapacities;
    using Belien2007.A.E.O.InterfacesFactories.ParameterElements.Common.DayBedCapacities;

    internal sealed class cParameterElementFactory : IcParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public cParameterElementFactory()
        {
        }

        public IcParameterElement Create(
            IiIndexElement iIndexElement,
            INullableValue<int> value)
        {
            IcParameterElement parameterElement = null;

            try
            {
                parameterElement = new cParameterElement(
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