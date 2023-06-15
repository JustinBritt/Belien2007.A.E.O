namespace Belien2007.A.E.O.Classes.IndexElements.Common
{
    using log4net;

    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;

    internal sealed class d2IndexElement : Id2IndexElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d2IndexElement(
            PositiveInt value)
        {
            this.Value = value;
        }

        /// <inheritdoc/>
        public PositiveInt Value { get; }
    }
}