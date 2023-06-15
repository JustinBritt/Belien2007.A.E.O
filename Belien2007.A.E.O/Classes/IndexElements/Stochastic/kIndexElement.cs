namespace Belien2007.A.E.O.Classes.IndexElements.Stochastic
{
    using log4net;

    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;

    internal sealed class kIndexElement : IkIndexElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public kIndexElement(
            INullableValue<int> value)
        {
            this.Value = value;
        }

        /// <inheritdoc/>
        public INullableValue<int> Value { get; }

        /// <inheritdoc/>
        public int CompareTo(
            IkIndexElement other)
        {
            return this.Value.Value.Value.CompareTo(
                other.Value.Value.Value);
        }
    }
}