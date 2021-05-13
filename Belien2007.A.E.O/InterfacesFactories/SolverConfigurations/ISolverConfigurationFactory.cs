namespace Belien2007.A.E.O.InterfacesFactories.SolverConfigurations
{
    using Belien2007.A.E.O.Interfaces.SolverConfigurations;

    public interface ISolverConfigurationFactory
    {
        ISolverConfiguration Create(
            OPTANO.Modeling.Optimization.SolverConfiguration solverConfiguration);
    }
}