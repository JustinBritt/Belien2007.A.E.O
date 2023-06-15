namespace Belien2007.A.E.O.Factories.IndexElements.Common
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Classes.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.InterfacesFactories.IndexElements.Common;

    internal sealed class d2IndexElementFactory : Id2IndexElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d2IndexElementFactory()
        {
        }

        public Id2IndexElement Create(
            INullableValue<int> value)
        {
            Id2IndexElement indexElement = null;

            try
            {
                indexElement = new d2IndexElement(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return indexElement;
        }
    }
}