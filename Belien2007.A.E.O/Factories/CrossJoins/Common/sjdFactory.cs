namespace Belien2007.A.E.O.Factories.CrossJoins.Common
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Belien2007.A.E.O.Classes.CrossJoins.Common;
    using Belien2007.A.E.O.Interfaces.CrossJoinElements.Common;
    using Belien2007.A.E.O.Interfaces.CrossJoins.Common;
    using Belien2007.A.E.O.InterfacesFactories.CrossJoins.Common;

    internal sealed class sjdFactory : IsjdFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public sjdFactory()
        {
        }

        public Isjd Create(
            ImmutableList<IsjdCrossJoinElement> value)
        {
            Isjd crossJoin = null;

            try
            {
                crossJoin = new sjd(
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