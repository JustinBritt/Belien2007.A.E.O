namespace Belien2007.A.E.O.Factories.ObjectiveFunctions.MIP2
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Classes.ObjectiveFunctions.MIP2;
    using Belien2007.A.E.O.Interfaces.ObjectiveFunctions.MIP2;
    using Belien2007.A.E.O.Interfaces.Variables.MIP2;
    using Belien2007.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;
    using Belien2007.A.E.O.InterfacesFactories.ObjectiveFunctions.MIP2;

    internal sealed class MIP2ObjectiveFunctionFactory : IMIP2ObjectiveFunctionFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public MIP2ObjectiveFunctionFactory()
        {
        }

        public IMIP2ObjectiveFunction Create(
            IObjectiveFactory objectiveFactory,
            Iγ γ)
        {
            IMIP2ObjectiveFunction objectiveFunction = null;

            try
            {
                objectiveFunction = new MIP2ObjectiveFunction(
                    objectiveFactory,
                    γ);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return objectiveFunction;
        }
    }
}