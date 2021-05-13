namespace Belien2007.A.E.O.Classes.Constraints.QMIP
{
    using System.Collections.Immutable;

    using log4net;

    using Belien2007.A.E.O.Interfaces.ConstraintElements.QMIP;
    using Belien2007.A.E.O.Interfaces.Constraints.QMIP;

    internal sealed class QMIPConstraintsVariance : IQMIPConstraintsVariance
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public QMIPConstraintsVariance(
            ImmutableList<IQMIPConstraintsVarianceConstraintElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IQMIPConstraintsVarianceConstraintElement> Value { get; }
    }
}