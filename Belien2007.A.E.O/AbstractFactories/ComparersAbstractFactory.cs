namespace Belien2007.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Factories.Comparers;
    using Belien2007.A.E.O.InterfacesAbstractFactories;
    using Belien2007.A.E.O.InterfacesFactories.Comparers;

    internal sealed class ComparersAbstractFactory : IComparersAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ComparersAbstractFactory()
        {
        }

        public IOrganizationComparerFactory CreateOrganizationComparerFactory()
        {
            IOrganizationComparerFactory factory = null;

            try
            {
                factory = new OrganizationComparerFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }
    }
}