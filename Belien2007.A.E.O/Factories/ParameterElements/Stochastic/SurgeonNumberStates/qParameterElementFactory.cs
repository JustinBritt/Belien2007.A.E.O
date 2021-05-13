namespace Belien2007.A.E.O.Factories.ParameterElements.Stochastic.SurgeonNumberStates
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Classes.ParameterElements.Stochastic.SurgeonNumberStates;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Stochastic.SurgeonNumberStates;
    using Belien2007.A.E.O.InterfacesFactories.ParameterElements.Stochastic.SurgeonNumberStates;

    internal sealed class qParameterElementFactory : IqParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public qParameterElementFactory()
        {
        }

        public IqParameterElement Create(
            IsIndexElement sIndexElement,
            PositiveInt value)
        {
            IqParameterElement parameterElement = null;

            try
            {
                parameterElement = new qParameterElement(
                    sIndexElement,
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