namespace Belien2007.A.E.O.Factories.ConstraintElements.SMIP2
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Classes.ConstraintElements.SMIP2;
    using Belien2007.A.E.O.Interfaces.ConstraintElements.SMIP2;
    using Belien2007.A.E.O.Interfaces.CrossJoins.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Stochastic;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.ActivePeriods;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonDayLengthOfStayProbabilities;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonLengthOfStayMaximums;
    using Belien2007.A.E.O.Interfaces.Parameters.Stochastic.SurgeonStateMaximumNumberPatients;
    using Belien2007.A.E.O.Interfaces.Parameters.Stochastic.SurgeonStateProbabilities;
    using Belien2007.A.E.O.Interfaces.Variables.Common;
    using Belien2007.A.E.O.InterfacesFactories.ConstraintElements.SMIP2;

    internal sealed class ConstraintsμConstraintElementFactory : IConstraintsμConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ConstraintsμConstraintElementFactory()
        {
        }

        public IConstraintsμConstraintElement Create(
            IiIndexElement iIndexElement,
            Id d,
            Ii i,
            Ij j,
            Ik k,
            Is s,
            Isj sj,
            IA A,
            Ih h,
            Im m,
            IStochasticn n,
            Ip p,
            Ix x,
            Iμ μ)
        {
            IConstraintsμConstraintElement constraintElement = null;

            try
            {
                constraintElement = new ConstraintsμConstraintElement(
                    iIndexElement,
                    d,
                    i,
                    j,
                    k,
                    s,
                    sj,
                    A,
                    h,
                    m,
                    n,
                    p,
                    x,
                    μ);
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