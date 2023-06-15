namespace Belien2007.A.E.O.Classes.IndexElements.Common
{
    using log4net;

    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;

    internal sealed class iIndexElement : IiIndexElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public iIndexElement(
            int key,
            FhirDateTime value)
        {
            this.Key = key;

            this.Value = value;
        }

        /// <inheritdoc/>
        public int Key { get; }

        /// <inheritdoc/>
        public FhirDateTime Value { get; }

        /// <inheritdoc/>
        public int CompareTo(
            IiIndexElement other)
        {
            return this.Key.CompareTo(
                other.Key);
        }
    }
}