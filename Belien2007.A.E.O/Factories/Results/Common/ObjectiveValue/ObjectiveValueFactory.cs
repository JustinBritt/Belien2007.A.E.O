namespace Belien2007.A.E.O.Factories.Results.Common.ObjectiveValue
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Classes.Results.Common.ObjectiveValue;
    using Belien2007.A.E.O.Interfaces.Results.Common.ObjectiveValue;
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.ObjectiveValue;

    internal sealed class ObjectiveValueFactory : IObjectiveValueFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ObjectiveValueFactory()
        {
        }

        public IObjectiveValue Create(
            decimal value)
        {
            IObjectiveValue result = null;

            try
            {
                result = new ObjectiveValue(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return result;
        }
    }
}