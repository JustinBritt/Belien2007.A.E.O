namespace Belien2007.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Factories.CrossJoinElements.Common;
    using Belien2007.A.E.O.Factories.CrossJoinElements.Stochastic;
    using Belien2007.A.E.O.InterfacesAbstractFactories;
    using Belien2007.A.E.O.InterfacesFactories.CrossJoinElements.Common;
    using Belien2007.A.E.O.InterfacesFactories.CrossJoinElements.Stochastic;

    internal sealed class CrossJoinElementsAbstractFactory : ICrossJoinElementsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CrossJoinElementsAbstractFactory()
        {
        }

        public Id1d2CrossJoinElementFactory Created1d2CrossJoinElementFactory()
        {
            Id1d2CrossJoinElementFactory factory = null;

            try
            {
                factory = new d1d2CrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IsiCrossJoinElementFactory CreatesiCrossJoinElementFactory()
        {
            IsiCrossJoinElementFactory factory = null;

            try
            {
                factory = new siCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IsjCrossJoinElementFactory CreatesjCrossJoinElementFactory()
        {
            IsjCrossJoinElementFactory factory = null;

            try
            {
                factory = new sjCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IsjdCrossJoinElementFactory CreatesjdCrossJoinElementFactory()
        {
            IsjdCrossJoinElementFactory factory = null;

            try
            {
                factory = new sjdCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public Isjd1CrossJoinElementFactory Createsjd1CrossJoinElementFactory()
        {
            Isjd1CrossJoinElementFactory factory = null;

            try
            {
                factory = new sjd1CrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public Isjd1d2CrossJoinElementFactory Createsjd1d2CrossJoinElementFactory()
        {
            Isjd1d2CrossJoinElementFactory factory = null;

            try
            {
                factory = new sjd1d2CrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IskCrossJoinElementFactory CreateskCrossJoinElementFactory()
        {
            IskCrossJoinElementFactory factory = null;

            try
            {
                factory = new skCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }
    }
}