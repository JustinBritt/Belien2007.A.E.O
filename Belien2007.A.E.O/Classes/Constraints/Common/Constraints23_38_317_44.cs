namespace Belien2007.A.E.O.Classes.Constraints.Common
{
    using System.Collections.Immutable;

    using log4net;

    using Belien2007.A.E.O.Interfaces.ConstraintElements.Common;
    using Belien2007.A.E.O.Interfaces.Constraints.Common;

    internal sealed class Constraints23_38_317_44 : IConstraints23_38_317_44
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints23_38_317_44(
            ImmutableList<IConstraints23_38_317_44_ConstraintElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IConstraints23_38_317_44_ConstraintElement> Value { get; }
    }
}