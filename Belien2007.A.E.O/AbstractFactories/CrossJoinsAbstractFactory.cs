namespace Belien2007.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Factories.CrossJoins.Common;
    using Belien2007.A.E.O.Factories.CrossJoins.Stochastic;
    using Belien2007.A.E.O.InterfacesAbstractFactories;
    using Belien2007.A.E.O.InterfacesFactories.CrossJoins.Common;
    using Belien2007.A.E.O.InterfacesFactories.CrossJoins.Stochastic;

    internal sealed class CrossJoinsAbstractFactory : ICrossJoinsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CrossJoinsAbstractFactory()
        {
        }

        public Id1d2Factory Created1d2Factory()
        {
            Id1d2Factory factory = null;

            try
            {
                factory = new d1d2Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IsiFactory CreatesiFactory()
        {
            IsiFactory factory = null;

            try
            {
                factory = new siFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IsjFactory CreatesjFactory()
        {
            IsjFactory factory = null;

            try
            {
                factory = new sjFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IsjdFactory CreatesjdFactory()
        {
            IsjdFactory factory = null;

            try
            {
                factory = new sjdFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public Isjd1Factory Createsjd1Factory()
        {
            Isjd1Factory factory = null;

            try
            {
                factory = new sjd1Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public Isjd1d2Factory Createsjd1d2Factory()
        {
            Isjd1d2Factory factory = null;

            try
            {
                factory = new sjd1d2Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IskFactory CreateskFactory()
        {
            IskFactory factory = null;

            try
            {
                factory = new skFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }
    }
}