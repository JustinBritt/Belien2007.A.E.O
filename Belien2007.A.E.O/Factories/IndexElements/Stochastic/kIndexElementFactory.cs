namespace Belien2007.A.E.O.Factories.IndexElements.Stochastic
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Classes.IndexElements.Stochastic;
    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;
    using Belien2007.A.E.O.InterfacesFactories.IndexElements.Stochastic;

    internal sealed class kIndexElementFactory : IkIndexElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public kIndexElementFactory()
        {
        }

        public IkIndexElement Create(
            INullableValue<int> value)
        {
            IkIndexElement indexElement = null;

            try
            {
                indexElement = new kIndexElement(
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