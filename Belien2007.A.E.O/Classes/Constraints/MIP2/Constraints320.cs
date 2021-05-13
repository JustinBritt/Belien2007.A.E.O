namespace Belien2007.A.E.O.Classes.Constraints.MIP2
{
    using System.Collections.Immutable;

    using log4net;

    using Belien2007.A.E.O.Interfaces.ConstraintElements.MIP2;
    using Belien2007.A.E.O.Interfaces.Constraints.MIP2;

    internal sealed class Constraints320 : IConstraints320
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints320(
            ImmutableList<IConstraints320ConstraintElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IConstraints320ConstraintElement> Value { get; }
    }
}