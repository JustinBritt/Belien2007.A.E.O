﻿namespace Belien2007.A.E.O.Interfaces.IndexElements.Common
{
    using Hl7.Fhir.Model;

    public interface Id2IndexElement
    {
        /// <summary>
        /// Gets the day.
        /// </summary>
        INullableValue<int> Value { get; }
    }
}