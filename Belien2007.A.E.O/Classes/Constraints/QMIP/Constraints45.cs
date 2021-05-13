namespace Belien2007.A.E.O.Classes.Constraints.QMIP
{
    using System.Collections.Immutable;

    using log4net;

    using Belien2007.A.E.O.Interfaces.ConstraintElements.QMIP;
    using Belien2007.A.E.O.Interfaces.Constraints.QMIP;

    internal sealed class Constraints45 : IConstraints45
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints45(
            ImmutableList<IConstraints45ConstraintElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IConstraints45ConstraintElement> Value { get; }
    }
}