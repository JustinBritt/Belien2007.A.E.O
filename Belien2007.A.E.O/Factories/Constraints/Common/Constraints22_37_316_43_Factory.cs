namespace Belien2007.A.E.O.Factories.Constraints.Common
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Belien2007.A.E.O.Classes.Constraints.Common;
    using Belien2007.A.E.O.Interfaces.ConstraintElements.Common;
    using Belien2007.A.E.O.Interfaces.Constraints.Common;
    using Belien2007.A.E.O.InterfacesFactories.Constraints.Common;

    internal sealed class Constraints22_37_316_43_Factory : IConstraints22_37_316_43_Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints22_37_316_43_Factory()
        {
        }

        public IConstraints22_37_316_43 Create(
            ImmutableList<IConstraints22_37_316_43_ConstraintElement> value)
        {
            IConstraints22_37_316_43 constraint = null;

            try
            {
                constraint = new Constraints22_37_316_43(
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