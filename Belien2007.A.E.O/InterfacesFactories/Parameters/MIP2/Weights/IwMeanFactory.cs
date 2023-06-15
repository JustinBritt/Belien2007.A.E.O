namespace Belien2007.A.E.O.InterfacesFactories.Parameters.MIP2.Weights
{
    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.Parameters.MIP2.Weights;

    public interface IwMeanFactory
    {
        IwMean Create(
            INullableValue<decimal> value);
    }
}