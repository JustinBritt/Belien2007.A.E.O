namespace Belien2007.A.E.O.Interfaces.Parameters.Common.DayNumberAvailableTimeBlocks
{
    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.DayNumberAvailableTimeBlocks;

    public interface Ib
    {
        RedBlackTree<IiIndexElement, IbParameterElement> Value { get; }

        int GetElementAtAsint(
            IiIndexElement iIndexElement);
    }
}