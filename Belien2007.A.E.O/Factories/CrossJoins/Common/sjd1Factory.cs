namespace Belien2007.A.E.O.Factories.CrossJoins.Common
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Belien2007.A.E.O.Classes.CrossJoins.Common;
    using Belien2007.A.E.O.Interfaces.CrossJoinElements.Common;
    using Belien2007.A.E.O.Interfaces.CrossJoins.Common;
    using Belien2007.A.E.O.InterfacesFactories.CrossJoins.Common;

    internal sealed class sjd1Factory : Isjd1Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public sjd1Factory()
        {
        }

        public Isjd1 Create(
            ImmutableList<Isjd1CrossJoinElement> value)
        {
            Isjd1 crossJoin = null;

            try
            {
                crossJoin = new sjd1(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return crossJoin;
        }
    }
}