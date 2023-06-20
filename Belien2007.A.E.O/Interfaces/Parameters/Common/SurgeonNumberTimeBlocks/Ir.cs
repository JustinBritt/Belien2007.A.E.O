namespace Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonNumberTimeBlocks
{
    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.SurgeonNumberTimeBlocks;

    public interface Ir
    {
        RedBlackTree<IsIndexElement, IrParameterElement> Value { get; }

        int GetElementAtAsint(
            IsIndexElement sIndexElement);
    }
}