namespace Belien2007.A.E.O.InterfacesFactories.Results.Stochastic.StateNumberPatients
{
    using System.Collections.Immutable;

    using Belien2007.A.E.O.Interfaces.ResultElements.Stochastic.StateNumberPatients;
    using Belien2007.A.E.O.Interfaces.Results.Stochastic.StateNumberPatients;

    public interface IStateNumberPatientsFactory
    {
        IStateNumberPatients Create(
            ImmutableList<IStateNumberPatientsResultElement> value);
    }
}