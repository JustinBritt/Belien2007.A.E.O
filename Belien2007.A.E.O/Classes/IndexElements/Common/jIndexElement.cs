namespace Belien2007.A.E.O.Classes.IndexElements.Common
{
    using log4net;

    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;

    internal sealed class jIndexElement : IjIndexElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public jIndexElement(
            int key,
            FhirDateTime value)
        {
            this.Key = key;

            this.Value = value;
        }

        /// <summary>
        /// Gets the key of the day.
        /// </summary>
        public int Key { get; }

        /// <summary>
        /// Gets the value of the day.
        /// </summary>
        public FhirDateTime Value { get; }
    }
}