namespace Belien2007.A.E.O.Classes.Constraints.Common
{
    using System.Collections.Immutable;

    using log4net;

    using Belien2007.A.E.O.Interfaces.ConstraintElements.Common;
    using Belien2007.A.E.O.Interfaces.Constraints.Common;

    internal sealed class Constraints22_37_316_43 : IConstraints22_37_316_43
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints22_37_316_43(
            ImmutableList<IConstraints22_37_316_43_ConstraintElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IConstraints22_37_316_43_ConstraintElement> Value { get; }
    }
}