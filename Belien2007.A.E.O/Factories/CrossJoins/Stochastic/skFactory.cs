namespace Belien2007.A.E.O.Factories.CrossJoins.Stochastic
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Belien2007.A.E.O.Classes.CrossJoins.Stochastic;
    using Belien2007.A.E.O.Interfaces.CrossJoinElements.Stochastic;
    using Belien2007.A.E.O.Interfaces.CrossJoins.Stochastic;
    using Belien2007.A.E.O.InterfacesFactories.CrossJoins.Stochastic;

    internal sealed class skFactory : IskFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public skFactory()
        {
        }

        public Isk Create(
            ImmutableList<IskCrossJoinElement> value)
        {
            Isk crossJoin = null;

            try
            {
                crossJoin = new sk(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return crossJoin;
        }
    }
}