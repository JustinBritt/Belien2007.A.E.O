namespace Belien2007.A.E.O.Factories.ParameterElements.Common.SurgeonMaximumNumberPatients
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Classes.ParameterElements.Common.SurgeonMaximumNumberPatients;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.SurgeonMaximumNumberPatients;
    using Belien2007.A.E.O.InterfacesFactories.ParameterElements.Common.SurgeonMaximumNumberPatients;

    internal sealed class CommonnParameterElementFactory : ICommonnParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CommonnParameterElementFactory()
        {
        }

        public ICommonnParameterElement Create(
            IsIndexElement sIndexElement,
            INullableValue<int> value)
        {
            ICommonnParameterElement parameterElement = null;

            try
            {
                parameterElement = new CommonnParameterElement(
                    sIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameterElement;
        }
    }
}