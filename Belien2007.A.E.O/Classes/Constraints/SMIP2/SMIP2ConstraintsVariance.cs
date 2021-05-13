namespace Belien2007.A.E.O.Classes.Constraints.SMIP2
{
    using System.Collections.Immutable;

    using log4net;

    using Belien2007.A.E.O.Interfaces.ConstraintElements.SMIP2;
    using Belien2007.A.E.O.Interfaces.Constraints.SMIP2;

    internal sealed class SMIP2ConstraintsVariance : ISMIP2ConstraintsVariance
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SMIP2ConstraintsVariance(
            ImmutableList<ISMIP2ConstraintsVarianceConstraintElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<ISMIP2ConstraintsVarianceConstraintElement> Value { get; }
    }
}