namespace Belien2007.A.E.O.Factories.Constraints.MIP2
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Belien2007.A.E.O.Classes.Constraints.MIP2;
    using Belien2007.A.E.O.Interfaces.ConstraintElements.MIP2;
    using Belien2007.A.E.O.Interfaces.Constraints.MIP2;
    using Belien2007.A.E.O.InterfacesFactories.Constraints.MIP2;

    internal sealed class Constraints320Factory : IConstraints320Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints320Factory()
        {
        }

        public IConstraints320 Create(
            ImmutableList<IConstraints320ConstraintElement> value)
        {
            IConstraints320 constraint = null;

            try
            {
                constraint = new Constraints320(
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