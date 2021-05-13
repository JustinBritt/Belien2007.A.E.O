namespace Belien2007.A.E.O.Factories.ParameterElements.Stochastic.SurgeonStateProbabilities
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Classes.ParameterElements.Stochastic.SurgeonStateProbabilities;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Stochastic.SurgeonStateProbabilities;
    using Belien2007.A.E.O.InterfacesFactories.ParameterElements.Stochastic.SurgeonStateProbabilities;

    internal sealed class hParameterElementFactory : IhParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public hParameterElementFactory()
        {
        }

        public IhParameterElement Create(
            IsIndexElement sIndexElement,
            IkIndexElement kIndexElement,
            FhirDecimal value)
        {
            IhParameterElement parameterElement = null;

            try
            {
                parameterElement = new hParameterElement(
                    sIndexElement,
                    kIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return parameterElement;
        }
    }
}