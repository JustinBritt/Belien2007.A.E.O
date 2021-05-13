namespace Belien2007.A.E.O.Classes.CrossJoins.Stochastic
{
    using System.Collections.Immutable;

    using log4net;

    using Belien2007.A.E.O.Interfaces.CrossJoinElements.Stochastic;
    using Belien2007.A.E.O.Interfaces.CrossJoins.Stochastic;

    internal sealed class sk : Isk
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public sk(
            ImmutableList<IskCrossJoinElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IskCrossJoinElement> Value { get; }
    }
}