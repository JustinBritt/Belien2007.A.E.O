namespace Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonLengthOfStayMaximums
{
    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.SurgeonLengthOfStayMaximums;

    public interface Im
    {
        RedBlackTree<IsIndexElement, ImParameterElement> Value { get; }

        int GetElementAtAsint(
            IsIndexElement sIndexElement);
    }
}