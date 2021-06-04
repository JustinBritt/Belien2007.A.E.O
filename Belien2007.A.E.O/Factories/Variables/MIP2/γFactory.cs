namespace Belien2007.A.E.O.Factories.Variables.MIP2
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Belien2007.A.E.O.Classes.Variables.MIP2;
    using Belien2007.A.E.O.Interfaces.Variables.MIP2;
    using Belien2007.A.E.O.InterfacesFactories.Variables.MIP2;

    internal sealed class γFactory : IγFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public γFactory()
        {
        }

        public Iγ Create(
            Variable value)
        {
            Iγ variable = null;

            try
            {
                variable = new γ(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return variable;
        }
    }
}