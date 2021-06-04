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
    using Belien2007.A.E.O.Interfaces.Parameters.Stochastic.SurgeonNumberStates;
    using Belien2007.A.E.O.Interfaces.Parameters.Stochastic.SurgeonStateMaximumNumberPatients;
    using Belien2007.A.E.O.Interfaces.Parameters.Stochastic.SurgeonStateProbabilities;
    using Belien2007.A.E.O.Interfaces.Variables.Common;
    using Belien2007.A.E.O.InterfacesFactories.ConstraintElements.SMIP2;

    internal sealed class SMIP2ConstraintsVarianceConstraintElementFactory : ISMIP2ConstraintsVarianceConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SMIP2ConstraintsVarianceConstraintElementFactory()
        {
        }

        public ISMIP2ConstraintsVarianceConstraintElement Create(
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
            Iq q,
            Ix x,
            IVariance Variance)
        {
            ISMIP2ConstraintsVarianceConstraintElement constraintElement = null;

            try
            {
                constraintElement = new SMIP2ConstraintsVarianceConstraintElement(
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
                    q,
                    x,
                    Variance);
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