namespace Belien2007.A.E.O.InterfacesFactories.Parameters.Common.DayNumberAvailableTimeBlocks
{
    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.DayNumberAvailableTimeBlocks;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.DayNumberAvailableTimeBlocks;

    public interface IbFactory
    {
        Ib Create(
            RedBlackTree<IiIndexElement, IbParameterElement> value);
    }
}