namespace Belien2007.A.E.O.Interfaces.Exports.SMIP2
{
    using System.Threading.Tasks;

    using Belien2007.A.E.O.InterfacesAbstractFactories;
    using Belien2007.A.E.O.Interfaces.Configurations.SMIP2;
    using Belien2007.A.E.O.Interfaces.Contexts.SMIP2;
    using Belien2007.A.E.O.Interfaces.SolverConfigurations;

    public interface ISMIP2Export
    {
        Task<ISMIP2OutputContext> Solve(
            IAbstractFactory abstractFactory,
            ISMIP2Configuration SMIP2Configuration,
            ISMIP2InputContext SMIP2InputContext,
            ISolverConfiguration solverConfiguration);
    }
}