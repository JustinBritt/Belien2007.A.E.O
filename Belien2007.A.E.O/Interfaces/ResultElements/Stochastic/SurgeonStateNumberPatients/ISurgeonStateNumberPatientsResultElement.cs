namespace Belien2007.A.E.O.Interfaces.ResultElements.Stochastic.SurgeonStateNumberPatients
{
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;

    public interface ISurgeonStateNumberPatientsResultElement
    {
        IsIndexElement sIndexElement { get; }

        IkIndexElement kIndexElement { get; }

        int Value { get; }
    }
}