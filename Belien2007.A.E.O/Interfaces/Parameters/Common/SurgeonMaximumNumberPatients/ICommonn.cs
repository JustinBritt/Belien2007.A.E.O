namespace Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonMaximumNumberPatients
{
    using System.Collections.Immutable;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.SurgeonMaximumNumberPatients;

    public interface ICommonn
    {
        ImmutableList<ICommonnParameterElement> Value { get; }

        int GetElementAtAsint(
            IsIndexElement sIndexElement);
    }
}