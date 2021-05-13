namespace Belien2007.A.E.O.Factories.ConstraintElements.QMIP
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Classes.ConstraintElements.QMIP;
    using Belien2007.A.E.O.Interfaces.ConstraintElements.QMIP;
    using Belien2007.A.E.O.Interfaces.CrossJoins.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.ActivePeriods;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonDayLengthOfStayProbabilities;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonLengthOfStayMaximums;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonMaximumNumberPatients;
    using Belien2007.A.E.O.Interfaces.Variables.Common;
    using Belien2007.A.E.O.InterfacesFactories.ConstraintElements.QMIP;

    internal sealed class Constraints45ConstraintElementFactory : IConstraints45ConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints45ConstraintElementFactory()
        {
        }

        public IConstraints45ConstraintElement Create(
            IiIndexElement iIndexElement,
            Id d,
            Ii i,
            Ij j,
            Is s,
            Isj sj,
            IA A,
            Im m,
            ICommonn n,
            Ip p,
            Ix x,
            Iμ μ)
        {
            IConstraints45ConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints45ConstraintElement(
                    iIndexElement,
                    d,
                    i,
                    j,
                    s,
                    sj,
                    A,
                    m,
                    n,
                    p,
                    x,
                    μ);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return constraintElement;
        }
    }
}