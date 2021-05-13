namespace Belien2007.A.E.O.Factories.ParameterElements.Stochastic.SurgeonStateMaximumNumberPatients
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Classes.ParameterElements.Stochastic.SurgeonStateMaximumNumberPatients;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Stochastic.SurgeonStateMaximumNumberPatients;
    using Belien2007.A.E.O.InterfacesFactories.ParameterElements.Stochastic.SurgeonStateMaximumNumberPatients;

    internal sealed class StochasticnParameterElementFactory : IStochasticnParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public StochasticnParameterElementFactory()
        {
        }

        public IStochasticnParameterElement Create(
            IsIndexElement sIndexElement,
            IkIndexElement kIndexElement,
            PositiveInt value)
        {
            IStochasticnParameterElement parameterElement = null;

            try
            {
                parameterElement = new StochasticnParameterElement(
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