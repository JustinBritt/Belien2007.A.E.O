namespace Belien2007.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Factories.IndexElements.Common;
    using Belien2007.A.E.O.Factories.IndexElements.Stochastic;
    using Belien2007.A.E.O.InterfacesAbstractFactories;
    using Belien2007.A.E.O.InterfacesFactories.IndexElements.Common;
    using Belien2007.A.E.O.InterfacesFactories.IndexElements.Stochastic;

    internal sealed class IndexElementsAbstractFactory : IIndexElementsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IndexElementsAbstractFactory()
        {
        }

        public IdIndexElementFactory CreatedIndexElementFactory()
        {
            IdIndexElementFactory factory = null;

            try
            {
                factory = new dIndexElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public Id1IndexElementFactory Created1IndexElementFactory()
        {
            Id1IndexElementFactory factory = null;

            try
            {
                factory = new d1IndexElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public Id2IndexElementFactory Created2IndexElementFactory()
        {
            Id2IndexElementFactory factory = null;

            try
            {
                factory = new d2IndexElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IiIndexElementFactory CreateiIndexElementFactory()
        {
            IiIndexElementFactory factory = null;

            try
            {
                factory = new iIndexElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IjIndexElementFactory CreatejIndexElementFactory()
        {
            IjIndexElementFactory factory = null;

            try
            {
                factory = new jIndexElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IkIndexElementFactory CreatekIndexElementFactory()
        {
            IkIndexElementFactory factory = null;

            try
            {
                factory = new kIndexElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IsIndexElementFactory CreatesIndexElementFactory()
        {
            IsIndexElementFactory factory = null;

            try
            {
                factory = new sIndexElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }
    }
}