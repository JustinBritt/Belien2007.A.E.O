namespace Belien2007.A.E.O.Factories.Solutions.SMIP2
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Classes.Solutions.SMIP2;
    using Belien2007.A.E.O.Interfaces.Solutions.SMIP2;
    using Belien2007.A.E.O.InterfacesFactories.Solutions.SMIP2;

    internal sealed class SMIP2SolutionFactory : ISMIP2SolutionFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SMIP2SolutionFactory()
        {
        }

        public ISMIP2Solution Create()
        {
            ISMIP2Solution solution = null;

            try
            {
                solution = new SMIP2Solution();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return solution;
        }
    }
}