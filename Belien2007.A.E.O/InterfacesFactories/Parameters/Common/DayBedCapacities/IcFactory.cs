namespace Belien2007.A.E.O.InterfacesFactories.Parameters.Common.DayBedCapacities
{
    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.DayBedCapacities;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.DayBedCapacities;

    public interface IcFactory
    {
        Ic Create(
            RedBlackTree<IiIndexElement, IcParameterElement> value);
    }
}