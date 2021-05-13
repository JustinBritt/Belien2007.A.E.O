namespace Belien2007.A.E.O.Factories.Constraints.SMIP2
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using Belien2007.A.E.O.Classes.Constraints.SMIP2;
    using Belien2007.A.E.O.Interfaces.ConstraintElements.SMIP2;
    using Belien2007.A.E.O.Interfaces.Constraints.SMIP2;
    using Belien2007.A.E.O.InterfacesFactories.Constraints.SMIP2;

    internal sealed class SMIP2ConstraintsVarianceFactory : ISMIP2ConstraintsVarianceFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SMIP2ConstraintsVarianceFactory()
        {
        }

        public ISMIP2ConstraintsVariance Create(
            ImmutableList<ISMIP2ConstraintsVarianceConstraintElement> value)
        {
            ISMIP2ConstraintsVariance constraint = null;

            try
            {
                constraint = new SMIP2ConstraintsVariance(
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