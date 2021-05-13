namespace Belien2007.A.E.O.InterfacesFactories.Results.Stochastic.SurgeonStateNumberPatients
{
    using System.Collections.Immutable;

    using Belien2007.A.E.O.Interfaces.ResultElements.Stochastic.SurgeonStateNumberPatients;
    using Belien2007.A.E.O.Interfaces.Results.Stochastic.SurgeonStateNumberPatients;

    public interface ISurgeonStateNumberPatientsFactory
    {
        ISurgeonStateNumberPatients Create(
            ImmutableList<ISurgeonStateNumberPatientsResultElement> value);
    }
}