namespace Belien2007.A.E.O.Factories.ConstraintElements.Common
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Classes.ConstraintElements.Common;
    using Belien2007.A.E.O.Interfaces.ConstraintElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.ActivePeriods;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonNumberTimeBlocks;
    using Belien2007.A.E.O.Interfaces.Variables.Common;
    using Belien2007.A.E.O.InterfacesFactories.ConstraintElements.Common;

    internal sealed class Constraints22_37_316_43_ConstraintElement_Factory : IConstraints22_37_316_43_ConstraintElement_Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints22_37_316_43_ConstraintElement_Factory()
        {
        }

        public IConstraints22_37_316_43_ConstraintElement Create(
            IsIndexElement sIndexElement,
            Ii i,
            IA A,
            Ir r,
            Ix x)
        {
            IConstraints22_37_316_43_ConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints22_37_316_43_ConstraintElement(
                    sIndexElement,
                    i,
                    A,
                    r,
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