namespace Belien2007.A.E.O.Interfaces.Exports.MIP2
{
    using System.Threading.Tasks;

    using Belien2007.A.E.O.InterfacesAbstractFactories;
    using Belien2007.A.E.O.Interfaces.Configurations.MIP2;
    using Belien2007.A.E.O.Interfaces.Contexts.MIP2;
    using Belien2007.A.E.O.Interfaces.SolverConfigurations;

    public interface IMIP2Export
    {
        Task<IMIP2OutputContext> Solve(
            IAbstractFactory abstractFactory,
            IMIP2Configuration MIP2Configuration,
            IMIP2InputContext MIP2InputContext,
            ISolverConfiguration solverConfiguration);
    }
}