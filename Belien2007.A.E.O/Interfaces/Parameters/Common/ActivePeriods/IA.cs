namespace Belien2007.A.E.O.Interfaces.Parameters.Common.ActivePeriods
{
    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.ActivePeriods;

    public interface IA
    {
        RedBlackTree<IiIndexElement, IAParameterElement> Value { get; }

        int GetElementAtAsint(
            IiIndexElement iIndexElement);

        int GetElementAtAsint(
            IjIndexElement jIndexElement);
    }
}