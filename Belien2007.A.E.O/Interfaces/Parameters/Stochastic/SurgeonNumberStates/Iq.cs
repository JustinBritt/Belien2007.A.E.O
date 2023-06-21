namespace Belien2007.A.E.O.Interfaces.Parameters.Stochastic.SurgeonNumberStates
{
    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Stochastic.SurgeonNumberStates;

    public interface Iq
    {
        RedBlackTree<IsIndexElement, IqParameterElement> Value { get; }

        int GetElementAtAsint(
            IsIndexElement sIndexElement);
    }
}