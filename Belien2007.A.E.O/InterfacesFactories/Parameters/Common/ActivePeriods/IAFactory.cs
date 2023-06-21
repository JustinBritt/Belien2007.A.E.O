namespace Belien2007.A.E.O.InterfacesFactories.Parameters.Common.ActivePeriods
{
    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.ActivePeriods;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.ActivePeriods;

    public interface IAFactory
    {
        IA Create(
            RedBlackTree<IiIndexElement, IAParameterElement> value);
    }
}