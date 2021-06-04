namespace Belien2007.A.E.O.Factories.Solutions.QMIP
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Classes.Solutions.QMIP;
    using Belien2007.A.E.O.Interfaces.Solutions.QMIP;
    using Belien2007.A.E.O.InterfacesFactories.Solutions.QMIP;

    internal sealed class QMIPSolutionFactory : IQMIPSolutionFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public QMIPSolutionFactory()
        {
        }

        public IQMIPSolution Create()
        {
            IQMIPSolution solution = null;

            try
            {
                solution = new QMIPSolution();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return solution;
        }
    }
}