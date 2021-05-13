namespace Belien2007.A.E.O.InterfacesFactories.ObjectiveFunctions.QMIP
{
    using Belien2007.A.E.O.Interfaces.ObjectiveFunctions.QMIP;
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.ActivePeriods;
    using Belien2007.A.E.O.Interfaces.Variables.Common;
    using Belien2007.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;

    public interface IQMIPObjectiveFunctionFactory
    {
        IQMIPObjectiveFunction Create(
            IObjectiveFactory objectiveFactory,
            Ii i,
            IA A,
            Iμ μ);
    }
}