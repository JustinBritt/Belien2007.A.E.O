namespace Belien2007.A.E.O.Interfaces.IndexElements.Stochastic
{
    using Hl7.Fhir.Model;

    public interface IkIndexElement
    {
        /// <summary>
        /// Gets the state.
        /// </summary>
        INullableValue<int> Value { get; }
    }
}