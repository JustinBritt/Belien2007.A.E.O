namespace Belien2007.A.E.O.Interfaces.Parameters.Stochastic.SurgeonStateProbabilities
{
    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Stochastic.SurgeonStateProbabilities;

    public interface Ih
    {
        RedBlackTree<IsIndexElement, RedBlackTree<IkIndexElement, IhParameterElement>> Value { get; }

        decimal GetElementAtAsdecimal(
            IsIndexElement sIndexElement,
            IkIndexElement kIndexElement);
    }
}