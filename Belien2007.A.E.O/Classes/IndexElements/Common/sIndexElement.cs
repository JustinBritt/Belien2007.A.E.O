namespace Belien2007.A.E.O.Classes.IndexElements.Common
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;

    internal sealed class sIndexElement : IsIndexElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public sIndexElement(
            Organization value)
        {
            this.Value = value;
        }

        /// <inheritdoc/>
        public Organization Value { get; }

        /// <inheritdoc/>
        public int CompareTo(
            IsIndexElement other)
        {
            return String.CompareOrdinal(
                other.Value.Id,
                this.Value.Id);
        }
    }
}