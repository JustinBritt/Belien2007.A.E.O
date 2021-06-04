namespace Belien2007.A.E.O.Factories.Constraints.MIP2
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Belien2007.A.E.O.Classes.Constraints.MIP2;
    using Belien2007.A.E.O.Interfaces.ConstraintElements.MIP2;
    using Belien2007.A.E.O.Interfaces.Constraints.MIP2;
    using Belien2007.A.E.O.InterfacesFactories.Constraints.MIP2;

    internal sealed class Constraints318Factory : IConstraints318Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints318Factory()
        {
        }

        public IConstraints318 Create(
            ImmutableList<IConstraints318ConstraintElement> value)
        {
            IConstraints318 constraint = null;

            try
            {
                constraint = new Constraints318(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return constraint;
        }
    }
}