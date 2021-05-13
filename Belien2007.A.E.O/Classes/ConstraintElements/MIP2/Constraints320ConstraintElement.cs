namespace Belien2007.A.E.O.Classes.ConstraintElements.MIP2
{
    using log4net;

    using OPTANO.Modeling.Optimization;

    using Belien2007.A.E.O.Interfaces.ConstraintElements.MIP2;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Parameters.MIP2.Weights;
    using Belien2007.A.E.O.Interfaces.Variables.Common;
    using Belien2007.A.E.O.Interfaces.Variables.MIP2;

    internal sealed class Constraints320ConstraintElement : IConstraints320ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints320ConstraintElement(
            IiIndexElement iIndexElement,
            IwMean wMean,
            IwVariance wVariance,
            Iγ γ,
            Iμ μ,
            IVariance Variance)
        {
            Expression LHS =
                (double)wMean.Value.Value.Value
                *
                μ.Value[iIndexElement]
                +
                (double)wVariance.Value.Value.Value
                *
                Variance.Value[iIndexElement];

            Expression RHS = γ.Value;

            this.Value = LHS <= RHS;
        }

        public Constraint Value { get; }
    }
}