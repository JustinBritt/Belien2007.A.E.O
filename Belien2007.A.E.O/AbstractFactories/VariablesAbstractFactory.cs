namespace Belien2007.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Factories.Variables.Common;
    using Belien2007.A.E.O.Factories.Variables.MIP2;
    using Belien2007.A.E.O.InterfacesAbstractFactories;
    using Belien2007.A.E.O.InterfacesFactories.Variables.Common;
    using Belien2007.A.E.O.InterfacesFactories.Variables.MIP2;

    internal sealed class VariablesAbstractFactory : IVariablesAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VariablesAbstractFactory()
        {
        }

        public IVarianceFactory CreateVarianceFactory()
        {
            IVarianceFactory factory = null;

            try
            {
                factory = new VarianceFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IxFactory CreatexFactory()
        {
            IxFactory factory = null;

            try
            {
                factory = new xFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IγFactory CreateγFactory()
        {
            IγFactory factory = null;

            try
            {
                factory = new γFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IμFactory CreateμFactory()
        {
            IμFactory factory = null;

            try
            {
                factory = new μFactory();
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