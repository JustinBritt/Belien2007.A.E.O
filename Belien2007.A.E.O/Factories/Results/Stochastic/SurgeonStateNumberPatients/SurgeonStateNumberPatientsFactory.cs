namespace Belien2007.A.E.O.Factories.Results.Stochastic.SurgeonStateNumberPatients
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Belien2007.A.E.O.Classes.Results.Stochastic.SurgeonStateNumberPatients;
    using Belien2007.A.E.O.Interfaces.ResultElements.Stochastic.SurgeonStateNumberPatients;
    using Belien2007.A.E.O.Interfaces.Results.Stochastic.SurgeonStateNumberPatients;
    using Belien2007.A.E.O.InterfacesFactories.Results.Stochastic.SurgeonStateNumberPatients;

    internal sealed class SurgeonStateNumberPatientsFactory : ISurgeonStateNumberPatientsFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonStateNumberPatientsFactory()
        {
        }

        public ISurgeonStateNumberPatients Create(
            ImmutableList<ISurgeonStateNumberPatientsResultElement> value)
        {
            ISurgeonStateNumberPatients result = null;

            try
            {
                result = new SurgeonStateNumberPatients(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return result;
        }
    }
}