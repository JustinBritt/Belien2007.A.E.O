namespace Belien2007.A.E.O.Classes.CrossJoins.Common
{
    using System.Collections.Immutable;

    using log4net;

    using Belien2007.A.E.O.Interfaces.CrossJoinElements.Common;
    using Belien2007.A.E.O.Interfaces.CrossJoins.Common;

    internal sealed class sjd1d2 : Isjd1d2
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public sjd1d2(
            ImmutableList<Isjd1d2CrossJoinElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<Isjd1d2CrossJoinElement> Value { get; }
    }
}