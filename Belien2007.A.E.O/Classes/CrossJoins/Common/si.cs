namespace Belien2007.A.E.O.Classes.CrossJoins.Common
{
    using System.Collections.Immutable;

    using log4net;

    using Belien2007.A.E.O.Interfaces.CrossJoinElements.Common;
    using Belien2007.A.E.O.Interfaces.CrossJoins.Common;

    internal sealed class si : Isi
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public si(
            ImmutableList<IsiCrossJoinElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IsiCrossJoinElement> Value { get; }
    }
}