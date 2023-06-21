namespace Belien2007.A.E.O.InterfacesFactories.Parameters.Stochastic.SurgeonNumberStates
{
    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Stochastic.SurgeonNumberStates;
    using Belien2007.A.E.O.Interfaces.Parameters.Stochastic.SurgeonNumberStates;

    public interface IqFactory
    {
        Iq Create(
            RedBlackTree<IsIndexElement, IqParameterElement> value);
    }
}