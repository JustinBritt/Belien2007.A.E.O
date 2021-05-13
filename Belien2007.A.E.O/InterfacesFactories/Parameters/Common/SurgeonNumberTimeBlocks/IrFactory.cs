namespace Belien2007.A.E.O.InterfacesFactories.Parameters.Common.SurgeonNumberTimeBlocks
{
    using System.Collections.Immutable;

    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.SurgeonNumberTimeBlocks;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonNumberTimeBlocks;

    public interface IrFactory
    {
        Ir Create(
            ImmutableList<IrParameterElement> value);
    }
}