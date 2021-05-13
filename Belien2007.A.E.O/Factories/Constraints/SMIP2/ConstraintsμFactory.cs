namespace Belien2007.A.E.O.Factories.Constraints.SMIP2
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Belien2007.A.E.O.Classes.Constraints.SMIP2;
    using Belien2007.A.E.O.Interfaces.ConstraintElements.SMIP2;
    using Belien2007.A.E.O.Interfaces.Constraints.SMIP2;
    using Belien2007.A.E.O.InterfacesFactories.Constraints.SMIP2;

    internal sealed class ConstraintsμFactory : IConstraintsμFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ConstraintsμFactory()
        {
        }

        public IConstraintsμ Create(
            ImmutableList<IConstraintsμConstraintElement> value)
        {
            IConstraintsμ constraint = null;

            try
            {
                constraint = new Constraintsμ(
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