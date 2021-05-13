namespace Belien2007.A.E.O.Interfaces.ObjectiveFunctions.QMIP
{
    using OPTANO.Modeling.Optimization;

    public interface IQMIPObjectiveFunction
    {
        Objective Value { get; }
    }
}