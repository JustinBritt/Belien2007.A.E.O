namespace Belien2007.A.E.O.Factories.ResultElements.Stochastic.SurgeonStateNumberPatients
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Classes.ResultElements.Stochastic.SurgeonStateNumberPatients;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;
    using Belien2007.A.E.O.Interfaces.ResultElements.Stochastic.SurgeonStateNumberPatients;
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Stochastic.SurgeonStateNumberPatients;

    internal sealed class SurgeonStateNumberPatientsResultElementFactory : ISurgeonStateNumberPatientsResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonStateNumberPatientsResultElementFactory()
        {
        }

        public ISurgeonStateNumberPatientsResultElement Create(
            IsIndexElement sIndexElement,
            IkIndexElement kIndexElement,
            int value)
        {
            ISurgeonStateNumberPatientsResultElement resultElement = null;

            try
            {
                resultElement = new SurgeonStateNumberPatientsResultElement(
                    sIndexElement,
                    kIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return resultElement;
        }
    }
}