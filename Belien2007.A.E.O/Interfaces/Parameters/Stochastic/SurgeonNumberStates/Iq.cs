namespace Belien2007.A.E.O.Interfaces.Parameters.Stochastic.SurgeonNumberStates
{
    using System.Collections.Immutable;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Stochastic.SurgeonNumberStates;

    public interface Iq
    {
        ImmutableList<IqParameterElement> Value { get; }

        int GetElementAtAsint(
            IsIndexElement sIndexElement);
    }
}