namespace Belien2007.A.E.O.InterfacesFactories.ConstraintElements.MIP2
{
    using Belien2007.A.E.O.Interfaces.ConstraintElements.MIP2;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Parameters.MIP2.Weights;
    using Belien2007.A.E.O.Interfaces.Variables.Common;
    using Belien2007.A.E.O.Interfaces.Variables.MIP2;

    public interface IConstraints320ConstraintElementFactory
    {
        IConstraints320ConstraintElement Create(
            IiIndexElement iIndexElement,
            IwMean wMean,
            IwVariance wVariance,
            Iγ γ,
            Iμ μ,
            IVariance Variance);
    }
}