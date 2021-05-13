namespace Belien2007.A.E.O.Classes.Parameters.MIP2.Weights
{
    using log4net;

    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.Parameters.MIP2.Weights;

    internal sealed class wMean : IwMean
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public wMean(
            FhirDecimal value)
        {
            this.Value = value;
        }

        public FhirDecimal Value { get; }
    }
}