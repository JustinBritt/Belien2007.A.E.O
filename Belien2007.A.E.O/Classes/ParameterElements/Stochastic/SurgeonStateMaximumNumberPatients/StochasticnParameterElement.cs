namespace Belien2007.A.E.O.Classes.ParameterElements.Stochastic.SurgeonStateMaximumNumberPatients
{
    using log4net;

    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Stochastic.SurgeonStateMaximumNumberPatients;

    internal sealed class StochasticnParameterElement : IStochasticnParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public StochasticnParameterElement(
            IsIndexElement sIndexElement,
            IkIndexElement kIndexElement,
            PositiveInt value)
        {
            this.sIndexElement = sIndexElement;

            this.kIndexElement = kIndexElement;

            this.Value = value;
        }

        public IsIndexElement sIndexElement { get; }

        public IkIndexElement kIndexElement { get; }

        public PositiveInt Value { get; }
    }
}