namespace Belien2007.A.E.O.Factories.ParameterElements.Common.SurgeonNumberTimeBlocks
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Classes.ParameterElements.Common.SurgeonNumberTimeBlocks;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.SurgeonNumberTimeBlocks;
    using Belien2007.A.E.O.InterfacesFactories.ParameterElements.Common.SurgeonNumberTimeBlocks;

    internal sealed class rParameterElementFactory : IrParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public rParameterElementFactory()
        {
        }

        public IrParameterElement Create(
            IsIndexElement sIndexElement,
            PositiveInt value)
        {
            IrParameterElement parameterElement = null;

            try
            {
                parameterElement = new rParameterElement(
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