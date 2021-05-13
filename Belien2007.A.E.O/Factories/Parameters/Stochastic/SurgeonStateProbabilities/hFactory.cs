namespace Belien2007.A.E.O.Factories.Parameters.Stochastic.SurgeonStateProbabilities
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Belien2007.A.E.O.Classes.Parameters.Stochastic.SurgeonStateProbabilities;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Stochastic.SurgeonStateProbabilities;
    using Belien2007.A.E.O.Interfaces.Parameters.Stochastic.SurgeonStateProbabilities;
    using Belien2007.A.E.O.InterfacesFactories.Parameters.Stochastic.SurgeonStateProbabilities;

    internal sealed class hFactory : IhFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public hFactory()
        {
        }

        public Ih Create(
            ImmutableList<IhParameterElement> value)
        {
            Ih parameter = null;

            try
            {
                parameter = new h(
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