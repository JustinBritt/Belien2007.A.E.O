namespace Belien2007.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Factories.Solutions.MIP2;
    using Belien2007.A.E.O.Factories.Solutions.QMIP;
    using Belien2007.A.E.O.Factories.Solutions.SMIP2;
    using Belien2007.A.E.O.InterfacesAbstractFactories;
    using Belien2007.A.E.O.InterfacesFactories.Solutions.MIP2;
    using Belien2007.A.E.O.InterfacesFactories.Solutions.QMIP;
    using Belien2007.A.E.O.InterfacesFactories.Solutions.SMIP2;

    internal sealed class SolutionsAbstractFactory : ISolutionsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SolutionsAbstractFactory()
        {
        }

        public IMIP2SolutionFactory CreateMIP2SolutionFactory()
        {
            IMIP2SolutionFactory factory = null;

            try
            {
                factory = new MIP2SolutionFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IQMIPSolutionFactory CreateQMIPSolutionFactory()
        {
            IQMIPSolutionFactory factory = null;

            try
            {
                factory = new QMIPSolutionFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ISMIP2SolutionFactory CreateSMIP2SolutionFactory()
        {
            ISMIP2SolutionFactory factory = null;

            try
            {
                factory = new SMIP2SolutionFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }
    }
}