namespace Belien2007.A.E.O.Classes.ParameterElements.Stochastic.SurgeonStateProbabilities
{
    using log4net;

    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Stochastic.SurgeonStateProbabilities;

    internal sealed class hParameterElement : IhParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public hParameterElement(
            IsIndexElement sIndexElement,
            IkIndexElement kIndexElement,
            INullableValue<decimal> value)
        {
            this.sIndexElement = sIndexElement;

            this.kIndexElement = kIndexElement;

            this.Value = value;
        }

        public IsIndexElement sIndexElement { get; }

        public IkIndexElement kIndexElement { get; }

        public INullableValue<decimal> Value { get; }
    }
}