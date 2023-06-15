namespace Belien2007.A.E.O.Interfaces.IndexElements.Common
{
    using System;

    using Hl7.Fhir.Model;

    public interface IjIndexElement : IComparable<IjIndexElement>
    {
        /// <summary>
        /// Gets the key of the day.
        /// </summary>
        int Key { get; }

        /// <summary>
        /// Gets the value of the day.
        /// </summary>
        FhirDateTime Value { get; }
    }
}