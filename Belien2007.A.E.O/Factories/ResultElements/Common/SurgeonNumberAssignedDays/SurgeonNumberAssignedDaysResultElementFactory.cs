namespace Belien2007.A.E.O.Factories.ResultElements.Common.SurgeonNumberAssignedDays
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Classes.ResultElements.Common.SurgeonNumberAssignedDays;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ResultElements.Common.SurgeonNumberAssignedDays;
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Common.SurgeonNumberAssignedDays;

    internal sealed class SurgeonNumberAssignedDaysResultElementFactory : ISurgeonNumberAssignedDaysResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonNumberAssignedDaysResultElementFactory()
        {
        }

        public ISurgeonNumberAssignedDaysResultElement Create(
            IsIndexElement sIndexElement,
            int value)
        {
            ISurgeonNumberAssignedDaysResultElement resultElement = null;

            try
            {
                resultElement = new SurgeonNumberAssignedDaysResultElement(
                    sIndexElement,
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