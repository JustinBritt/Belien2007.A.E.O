namespace Belien2007.A.E.O.InterfacesFactories.Parameters.Stochastic.SurgeonNumberStates
{
    using System.Collections.Immutable;

    using Belien2007.A.E.O.Interfaces.ParameterElements.Stochastic.SurgeonNumberStates;
    using Belien2007.A.E.O.Interfaces.Parameters.Stochastic.SurgeonNumberStates;

    public interface IqFactory
    {
        Iq Create(
            ImmutableList<IqParameterElement> value);
    }
}