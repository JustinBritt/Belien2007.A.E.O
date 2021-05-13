namespace Belien2007.A.E.O.Interfaces.IndexElements.Common
{
    using Hl7.Fhir.Model;

    public interface IdIndexElement
    {
        /// <summary>
        /// Gets the day.
        /// </summary>
        PositiveInt Value { get; }
    }
}