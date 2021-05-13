namespace Belien2007.A.E.O.InterfacesFactories.IndexElements.Stochastic
{
    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;

    public interface IkIndexElementFactory
    {
        IkIndexElement Create(
            PositiveInt value);
    }
}