namespace Belien2007.A.E.O.Factories.Constraints.QMIP
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Belien2007.A.E.O.Classes.Constraints.QMIP;
    using Belien2007.A.E.O.Interfaces.ConstraintElements.QMIP;
    using Belien2007.A.E.O.Interfaces.Constraints.QMIP;
    using Belien2007.A.E.O.InterfacesFactories.Constraints.QMIP;

    internal sealed class QMIPConstraintsVarianceFactory : IQMIPConstraintsVarianceFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public QMIPConstraintsVarianceFactory()
        {
        }

        public IQMIPConstraintsVariance Create(
            ImmutableList<IQMIPConstraintsVarianceConstraintElement> value)
        {
            IQMIPConstraintsVariance constraint = null;

            try
            {
                constraint = new QMIPConstraintsVariance(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return constraint;
        }
    }
}