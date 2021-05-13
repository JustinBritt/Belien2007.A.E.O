namespace Belien2007.A.E.O.Factories.Parameters.Stochastic.SurgeonNumberStates
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Belien2007.A.E.O.Classes.Parameters.Stochastic.SurgeonNumberStates;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Stochastic.SurgeonNumberStates;
    using Belien2007.A.E.O.Interfaces.Parameters.Stochastic.SurgeonNumberStates;
    using Belien2007.A.E.O.InterfacesFactories.Parameters.Stochastic.SurgeonNumberStates;

    internal sealed class qFactory : IqFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public qFactory()
        {
        }

        public Iq Create(
            ImmutableList<IqParameterElement> value)
        {
            Iq parameter = null;

            try
            {
                parameter = new q(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return parameter;
        }
    }
}