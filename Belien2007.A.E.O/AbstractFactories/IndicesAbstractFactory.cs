namespace Belien2007.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Factories.Indices.Common;
    using Belien2007.A.E.O.Factories.Indices.Stochastic;
    using Belien2007.A.E.O.InterfacesAbstractFactories;
    using Belien2007.A.E.O.InterfacesFactories.Indices.Common;
    using Belien2007.A.E.O.InterfacesFactories.Indices.Stochastic;

    internal sealed class IndicesAbstractFactory : IIndicesAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IndicesAbstractFactory()
        {
        }

        public IdFactory CreatedFactory()
        {
            IdFactory factory = null;

            try
            {
                factory = new dFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public Id1Factory Created1Factory()
        {
            Id1Factory factory = null;

            try
            {
                factory = new d1Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public Id2Factory Created2Factory()
        {
            Id2Factory factory = null;

            try
            {
                factory = new d2Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IiFactory CreateiFactory()
        {
            IiFactory factory = null;

            try
            {
                factory = new iFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IjFactory CreatejFactory()
        {
            IjFactory factory = null;

            try
            {
                factory = new jFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IkFactory CreatekFactory()
        {
            IkFactory factory = null;

            try
            {
                factory = new kFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IsFactory CreatesFactory()
        {
            IsFactory factory = null;

            try
            {
                factory = new sFactory();
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