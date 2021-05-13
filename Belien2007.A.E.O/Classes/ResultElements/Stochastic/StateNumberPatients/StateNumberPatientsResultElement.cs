namespace Belien2007.A.E.O.Classes.ResultElements.Stochastic.StateNumberPatients
{
    using log4net;

    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;
    using Belien2007.A.E.O.Interfaces.ResultElements.Stochastic.StateNumberPatients;

    internal sealed class StateNumberPatientsResultElement : IStateNumberPatientsResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public StateNumberPatientsResultElement(
            IkIndexElement kIndexElement,
            int value)
        {
            this.kIndexElement = kIndexElement;

            this.Value = value;
        }

        public IkIndexElement kIndexElement { get; }

        public int Value { get; }
    }
}