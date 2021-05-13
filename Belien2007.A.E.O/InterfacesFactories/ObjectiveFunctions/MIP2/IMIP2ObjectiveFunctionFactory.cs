namespace Belien2007.A.E.O.InterfacesFactories.ObjectiveFunctions.MIP2
{
    using Belien2007.A.E.O.Interfaces.ObjectiveFunctions.MIP2;
    using Belien2007.A.E.O.Interfaces.Variables.MIP2;
    using Belien2007.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;

    public interface IMIP2ObjectiveFunctionFactory
    {
        IMIP2ObjectiveFunction Create(
            IObjectiveFactory objectiveFactory,
            Iγ γ);
    }
}