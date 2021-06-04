namespace Belien2007.A.E.O.Factories.Constraints.MIP2
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Belien2007.A.E.O.Classes.Constraints.MIP2;
    using Belien2007.A.E.O.Interfaces.ConstraintElements.MIP2;
    using Belien2007.A.E.O.Interfaces.Constraints.MIP2;
    using Belien2007.A.E.O.InterfacesFactories.Constraints.MIP2;

    internal sealed class Constraints319Factory : IConstraints319Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints319Factory()
        {
        }

        public IConstraints319 Create(
            ImmutableList<IConstraints319ConstraintElement> value)
        {
            IConstraints319 constraint = null;

            try
            {
                constraint = new Constraints319(
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