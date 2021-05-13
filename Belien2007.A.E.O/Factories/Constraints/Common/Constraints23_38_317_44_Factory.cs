namespace Belien2007.A.E.O.Factories.Constraints.Common
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Belien2007.A.E.O.Classes.Constraints.Common;
    using Belien2007.A.E.O.Interfaces.ConstraintElements.Common;
    using Belien2007.A.E.O.Interfaces.Constraints.Common;
    using Belien2007.A.E.O.InterfacesFactories.Constraints.Common;

    internal sealed class Constraints23_38_317_44_Factory : IConstraints23_38_317_44_Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints23_38_317_44_Factory()
        {
        }

        public IConstraints23_38_317_44 Create(
            ImmutableList<IConstraints23_38_317_44_ConstraintElement> value)
        {
            IConstraints23_38_317_44 constraint = null;

            try
            {
                constraint = new Constraints23_38_317_44(
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