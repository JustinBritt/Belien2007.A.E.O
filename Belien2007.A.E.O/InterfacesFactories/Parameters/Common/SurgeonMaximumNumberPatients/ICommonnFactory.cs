namespace Belien2007.A.E.O.InterfacesFactories.Parameters.Common.SurgeonMaximumNumberPatients
{
    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.SurgeonMaximumNumberPatients;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonMaximumNumberPatients;

    public interface ICommonnFactory
    {
        ICommonn Create(
            RedBlackTree<IsIndexElement, ICommonnParameterElement> value);
    }
}