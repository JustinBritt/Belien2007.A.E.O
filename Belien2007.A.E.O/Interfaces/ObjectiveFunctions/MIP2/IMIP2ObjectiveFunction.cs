namespace Belien2007.A.E.O.Interfaces.ObjectiveFunctions.MIP2
{
    using OPTANO.Modeling.Optimization;

    public interface IMIP2ObjectiveFunction
    {
        Objective Value { get; }
    }
}