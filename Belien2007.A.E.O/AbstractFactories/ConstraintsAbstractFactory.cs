namespace Belien2007.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Factories.Constraints.Common;
    using Belien2007.A.E.O.Factories.Constraints.MIP2;
    using Belien2007.A.E.O.Factories.Constraints.QMIP;
    using Belien2007.A.E.O.Factories.Constraints.SMIP2;
    using Belien2007.A.E.O.InterfacesAbstractFactories;
    using Belien2007.A.E.O.InterfacesFactories.Constraints.Common;
    using Belien2007.A.E.O.InterfacesFactories.Constraints.MIP2;
    using Belien2007.A.E.O.InterfacesFactories.Constraints.QMIP;
    using Belien2007.A.E.O.InterfacesFactories.Constraints.SMIP2;

    internal sealed class ConstraintsAbstractFactory : IConstraintsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ConstraintsAbstractFactory()
        {
        }

        public IConstraints22_37_316_43_Factory Create_Constraints22_37_316_43_Factory()
        {
            IConstraints22_37_316_43_Factory factory = null;

            try
            {
                factory = new Constraints22_37_316_43_Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IConstraints23_38_317_44_Factory Create_Constraints23_38_317_44_Factory()
        {
            IConstraints23_38_317_44_Factory factory = null;

            try
            {
                factory = new Constraints23_38_317_44_Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IConstraints318Factory Create_Constraints318_Factory()
        {
            IConstraints318Factory factory = null;

            try
            {
                factory = new Constraints318Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IConstraints319Factory Create_Constraints319_Factory()
        {
            IConstraints319Factory factory = null;

            try
            {
                factory = new Constraints319Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IConstraints320Factory Create_Constraints320_Factory()
        {
            IConstraints320Factory factory = null;

            try
            {
                factory = new Constraints320Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IConstraints45Factory Create_Constraints45_Factory()
        {
            IConstraints45Factory factory = null;

            try
            {
                factory = new Constraints45Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IConstraintsμFactory Create_Constraintsμ_Factory()
        {
            IConstraintsμFactory factory = null;

            try
            {
                factory = new ConstraintsμFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IQMIPConstraintsVarianceFactory Create_QMIP_ConstraintsVariance_Factory()
        {
            IQMIPConstraintsVarianceFactory factory = null;

            try
            {
                factory = new QMIPConstraintsVarianceFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ISMIP2ConstraintsVarianceFactory Create_SMIP2_ConstraintsVariance_Factory()
        {
            ISMIP2ConstraintsVarianceFactory factory = null;

            try
            {
                factory = new SMIP2ConstraintsVarianceFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }
    }
}