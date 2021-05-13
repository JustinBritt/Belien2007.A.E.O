namespace Belien2007.A.E.O.Interfaces.Exports.QMIP
{
    using System.Threading.Tasks;

    using Belien2007.A.E.O.InterfacesAbstractFactories;
    using Belien2007.A.E.O.Interfaces.Configurations.QMIP;
    using Belien2007.A.E.O.Interfaces.Contexts.QMIP;
    using Belien2007.A.E.O.Interfaces.SolverConfigurations;

    public interface IQMIPExport
    {
        Task<IQMIPOutputContext> Solve(
            IAbstractFactory abstractFactory,
            IQMIPConfiguration QMIPConfiguration,
            IQMIPInputContext QMIPInputContext,
            ISolverConfiguration solverConfiguration);
    }
}