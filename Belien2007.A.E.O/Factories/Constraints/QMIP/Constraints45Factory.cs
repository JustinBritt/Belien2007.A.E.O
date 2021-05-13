namespace Belien2007.A.E.O.Factories.Constraints.QMIP
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Belien2007.A.E.O.Classes.Constraints.QMIP;
    using Belien2007.A.E.O.Interfaces.ConstraintElements.QMIP;
    using Belien2007.A.E.O.Interfaces.Constraints.QMIP;
    using Belien2007.A.E.O.InterfacesFactories.Constraints.QMIP;

    internal sealed class Constraints45Factory : IConstraints45Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints45Factory()
        {
        }

        public IConstraints45 Create(
            ImmutableList<IConstraints45ConstraintElement> value)
        {
            IConstraints45 constraint = null;

            try
            {
                constraint = new Constraints45(
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