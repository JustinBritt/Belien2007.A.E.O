namespace Belien2007.A.E.O.Factories.CrossJoins.Common
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Belien2007.A.E.O.Classes.CrossJoins.Common;
    using Belien2007.A.E.O.Interfaces.CrossJoinElements.Common;
    using Belien2007.A.E.O.Interfaces.CrossJoins.Common;
    using Belien2007.A.E.O.InterfacesFactories.CrossJoins.Common;

    internal sealed class sjd1d2Factory : Isjd1d2Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public sjd1d2Factory()
        {
        }

        public Isjd1d2 Create(
            ImmutableList<Isjd1d2CrossJoinElement> value)
        {
            Isjd1d2 crossJoin = null;

            try
            {
                crossJoin = new sjd1d2(
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