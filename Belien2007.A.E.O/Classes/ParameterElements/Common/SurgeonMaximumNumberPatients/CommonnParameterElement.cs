namespace Belien2007.A.E.O.Classes.ParameterElements.Common.SurgeonMaximumNumberPatients
{
    using log4net;

    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.SurgeonMaximumNumberPatients;

    internal sealed class CommonnParameterElement : ICommonnParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CommonnParameterElement(
            IsIndexElement sIndexElement,
            PositiveInt value)
        {
            this.sIndexElement = sIndexElement;

            this.Value = value;
        }

        public IsIndexElement sIndexElement { get; }

        public PositiveInt Value { get; }
    }
}