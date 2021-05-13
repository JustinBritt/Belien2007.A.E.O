namespace Belien2007.A.E.O.InterfacesFactories.ResultElements.Stochastic.StateNumberPatients
{
    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;
    using Belien2007.A.E.O.Interfaces.ResultElements.Stochastic.StateNumberPatients;

    public interface IStateNumberPatientsResultElementFactory
    {
        IStateNumberPatientsResultElement Create(
            IkIndexElement kIndexElement,
            int value);
    }
}