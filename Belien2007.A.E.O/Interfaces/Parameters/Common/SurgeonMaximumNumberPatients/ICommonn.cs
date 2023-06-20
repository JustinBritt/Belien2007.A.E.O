namespace Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonMaximumNumberPatients
{
    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.SurgeonMaximumNumberPatients;

    public interface ICommonn
    {
        RedBlackTree<IsIndexElement, ICommonnParameterElement> Value { get; }

        int GetElementAtAsint(
            IsIndexElement sIndexElement);
    }
}