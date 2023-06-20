namespace Belien2007.A.E.O.InterfacesFactories.Parameters.Common.SurgeonNumberTimeBlocks
{
    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.SurgeonNumberTimeBlocks;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonNumberTimeBlocks;

    public interface IrFactory
    {
        Ir Create(
            RedBlackTree<IsIndexElement, IrParameterElement> value);
    }
}