namespace Belien2007.A.E.O.Interfaces.ResultElements.Stochastic.StateNumberPatients
{
    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;

    public interface IStateNumberPatientsResultElement
    {
        IkIndexElement kIndexElement { get; }

        int Value { get; }
    }
}