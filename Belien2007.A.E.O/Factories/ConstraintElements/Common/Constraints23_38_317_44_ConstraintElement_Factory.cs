namespace Belien2007.A.E.O.Factories.ConstraintElements.Common
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Classes.ConstraintElements.Common;
    using Belien2007.A.E.O.Interfaces.ConstraintElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.DayNumberAvailableTimeBlocks;
    using Belien2007.A.E.O.Interfaces.Variables.Common;
    using Belien2007.A.E.O.InterfacesFactories.ConstraintElements.Common;

    internal sealed class Constraints23_38_317_44_ConstraintElement_Factory : IConstraints23_38_317_44_ConstraintElement_Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints23_38_317_44_ConstraintElement_Factory()
        {
        }

        public IConstraints23_38_317_44_ConstraintElement Create(
            IiIndexElement iIndexElement,
            Is s,
            Ib b,
            Ix x)
        {
            IConstraints23_38_317_44_ConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints23_38_317_44_ConstraintElement(
                    iIndexElement,
                    s,
                    b,
                    x);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return constraintElement;
        }
    }
}