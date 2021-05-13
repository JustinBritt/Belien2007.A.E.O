namespace Belien2007.A.E.O.Classes.ResultElements.Stochastic.SurgeonStateNumberPatients
{
    using log4net;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;
    using Belien2007.A.E.O.Interfaces.ResultElements.Stochastic.SurgeonStateNumberPatients;
    
    internal sealed class SurgeonStateNumberPatientsResultElement : ISurgeonStateNumberPatientsResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonStateNumberPatientsResultElement(
            IsIndexElement sIndexElement,
            IkIndexElement kIndexElement,
            int value)
        {
            this.sIndexElement = sIndexElement;

            this.kIndexElement = kIndexElement;

            this.Value = value;
        }

        public IsIndexElement sIndexElement { get; }

        public IkIndexElement kIndexElement { get; }

        public int Value { get; }
    }
}