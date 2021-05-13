namespace Belien2007.A.E.O.InterfacesFactories.ResultElements.Stochastic.SurgeonStateNumberPatients
{
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;
    using Belien2007.A.E.O.Interfaces.ResultElements.Stochastic.SurgeonStateNumberPatients;

    public interface ISurgeonStateNumberPatientsResultElementFactory
    {
        ISurgeonStateNumberPatientsResultElement Create(
            IsIndexElement sIndexElement,
            IkIndexElement kIndexElement,
            int value);
    }
}