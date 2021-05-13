namespace Belien2007.A.E.O.Factories.ConstraintElements.MIP2
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Classes.ConstraintElements.MIP2;
    using Belien2007.A.E.O.Interfaces.ConstraintElements.MIP2;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Parameters.MIP2.Weights;
    using Belien2007.A.E.O.Interfaces.Variables.Common;
    using Belien2007.A.E.O.Interfaces.Variables.MIP2;
    using Belien2007.A.E.O.InterfacesFactories.ConstraintElements.MIP2;

    internal sealed class Constraints320ConstraintElementFactory : IConstraints320ConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints320ConstraintElementFactory()
        {
        }

        public IConstraints320ConstraintElement Create(
            IiIndexElement iIndexElement,
            IwMean wMean,
            IwVariance wVariance,
            Iγ γ,
            Iμ μ,
            IVariance Variance)
        {
            IConstraints320ConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints320ConstraintElement(
                    iIndexElement,
                    wMean,
                    wVariance,
                    γ,
                    μ,
                    Variance);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return constraintElement;
        }
    }
}