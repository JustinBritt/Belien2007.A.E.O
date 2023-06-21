namespace Belien2007.A.E.O.InterfacesFactories.Parameters.Stochastic.SurgeonStateProbabilities
{
    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Stochastic.SurgeonStateProbabilities;
    using Belien2007.A.E.O.Interfaces.Parameters.Stochastic.SurgeonStateProbabilities;

    public interface IhFactory
    {
        Ih Create(
            RedBlackTree<IsIndexElement, RedBlackTree<IkIndexElement, IhParameterElement>> value);
    }
}