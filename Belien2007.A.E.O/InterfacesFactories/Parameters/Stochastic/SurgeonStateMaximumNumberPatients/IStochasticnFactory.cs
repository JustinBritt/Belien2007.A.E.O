namespace Belien2007.A.E.O.InterfacesFactories.Parameters.Stochastic.SurgeonStateMaximumNumberPatients
{
    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Stochastic.SurgeonStateMaximumNumberPatients;
    using Belien2007.A.E.O.Interfaces.Parameters.Stochastic.SurgeonStateMaximumNumberPatients;

    public interface IStochasticnFactory
    {
        IStochasticn Create(
            RedBlackTree<IsIndexElement, RedBlackTree<IkIndexElement, IStochasticnParameterElement>> value);
    }
}