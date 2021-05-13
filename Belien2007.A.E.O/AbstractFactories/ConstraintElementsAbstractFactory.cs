namespace Belien2007.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Factories.ConstraintElements.Common;
    using Belien2007.A.E.O.Factories.ConstraintElements.MIP2;
    using Belien2007.A.E.O.Factories.ConstraintElements.QMIP;
    using Belien2007.A.E.O.Factories.ConstraintElements.SMIP2;
    using Belien2007.A.E.O.InterfacesAbstractFactories;
    using Belien2007.A.E.O.InterfacesFactories.ConstraintElements.Common;
    using Belien2007.A.E.O.InterfacesFactories.ConstraintElements.MIP2;
    using Belien2007.A.E.O.InterfacesFactories.ConstraintElements.QMIP;
    using Belien2007.A.E.O.InterfacesFactories.ConstraintElements.SMIP2;

    internal sealed class ConstraintElementsAbstractFactory : IConstraintElementsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ConstraintElementsAbstractFactory()
        {
        }

        public IConstraints22_37_316_43_ConstraintElement_Factory Create_Constraints22_37_316_43_ConstraintElement_Factory()
        {
            IConstraints22_37_316_43_ConstraintElement_Factory factory = null;

            try
            {
                factory = new Constraints22_37_316_43_ConstraintElement_Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IConstraints23_38_317_44_ConstraintElement_Factory Create_Constraints23_38_317_44_ConstraintElement_Factory()
        {
            IConstraints23_38_317_44_ConstraintElement_Factory factory = null;

            try
            {
                factory = new Constraints23_38_317_44_ConstraintElement_Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IConstraints318ConstraintElementFactory CreateConstraints318ConstraintElementFactory()
        {
            IConstraints318ConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints318ConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IConstraints319ConstraintElementFactory CreateConstraints319ConstraintElementFactory()
        {
            IConstraints319ConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints319ConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IConstraints320ConstraintElementFactory CreateConstraints320ConstraintElementFactory()
        {
            IConstraints320ConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints320ConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IConstraints45ConstraintElementFactory CreateConstraints45ConstraintElementFactory()
        {
            IConstraints45ConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints45ConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IConstraintsμConstraintElementFactory CreateConstraintsμConstraintElementFactory()
        {
            IConstraintsμConstraintElementFactory factory = null;

            try
            {
                factory = new ConstraintsμConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IQMIPConstraintsVarianceConstraintElementFactory CreateQMIPConstraintsVarianceConstraintElementFactory()
        {
            IQMIPConstraintsVarianceConstraintElementFactory factory = null;

            try
            {
                factory = new QMIPConstraintsVarianceConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ISMIP2ConstraintsVarianceConstraintElementFactory CreateSMIP2ConstraintsVarianceConstraintElementFactory()
        {
            ISMIP2ConstraintsVarianceConstraintElementFactory factory = null;

            try
            {
                factory = new SMIP2ConstraintsVarianceConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }
    }
}