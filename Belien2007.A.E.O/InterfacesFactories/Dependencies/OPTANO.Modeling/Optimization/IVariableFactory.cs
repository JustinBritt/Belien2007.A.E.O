namespace Belien2007.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization
{
    using global::OPTANO.Modeling.Optimization;
    using global::OPTANO.Modeling.Optimization.Enums;

    public interface IVariableFactory
    {
        Variable Create();

        Variable Create(
            double lowerbound,
            VariableType type,
            double upperbound);

        Variable Create(
            double lowerbound,
            string name,
            VariableType type,
            double upperbound);
    }
}