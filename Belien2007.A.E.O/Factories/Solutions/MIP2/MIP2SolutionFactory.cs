namespace Belien2007.A.E.O.Factories.Solutions.MIP2
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Classes.Solutions.MIP2;
    using Belien2007.A.E.O.Interfaces.Solutions.MIP2;
    using Belien2007.A.E.O.InterfacesFactories.Solutions.MIP2;

    internal sealed class MIP2SolutionFactory : IMIP2SolutionFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public MIP2SolutionFactory()
        {
        }

        public IMIP2Solution Create()
        {
            IMIP2Solution solution = null;

            try
            {
                solution = new MIP2Solution();
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