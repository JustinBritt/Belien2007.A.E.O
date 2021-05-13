namespace Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonNumberTimeBlocks
{
    using System.Collections.Immutable;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.SurgeonNumberTimeBlocks;

    public interface Ir
    {
        ImmutableList<IrParameterElement> Value { get; }

        int GetElementAtAsint(
            IsIndexElement sIndexElement);
    }
}