namespace Belien2007.A.E.O.Factories.Dependencies.OPTANO.Modeling.Optimization
{
    using System;

    using log4net;

    using global::OPTANO.Modeling.Optimization;

    using Belien2007.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;

    internal sealed class ModelScopeFactory : IModelScopeFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ModelScopeFactory()
        {
        }

        public ModelScope Create()
        {
            ModelScope modelScope = null;

            try
            {
                modelScope = new ModelScope();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return modelScope;
        }

        public ModelScope Create(
            global::OPTANO.Modeling.Optimization.Configuration.Configuration configuration)
        {
            ModelScope modelScope = null;

            try
            {
                modelScope = new ModelScope(
                    configuration);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return modelScope;
        }
    }
}