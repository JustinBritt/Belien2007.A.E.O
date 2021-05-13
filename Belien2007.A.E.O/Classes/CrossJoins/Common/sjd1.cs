namespace Belien2007.A.E.O.Classes.CrossJoins.Common
{
    using System.Collections.Immutable;

    using log4net;

    using Belien2007.A.E.O.Interfaces.CrossJoinElements.Common;
    using Belien2007.A.E.O.Interfaces.CrossJoins.Common;

    internal sealed class sjd1 : Isjd1
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public sjd1(
            ImmutableList<Isjd1CrossJoinElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<Isjd1CrossJoinElement> Value { get; }
    }
}