namespace Belien2007.A.E.O.Interfaces.Parameters.Common.DayBedCapacities
{
    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.DayBedCapacities;

    public interface Ic
    {
        RedBlackTree<IiIndexElement, IcParameterElement> Value { get; }

        int GetElementAtAsint(
            IiIndexElement iIndexElement);
    }
}