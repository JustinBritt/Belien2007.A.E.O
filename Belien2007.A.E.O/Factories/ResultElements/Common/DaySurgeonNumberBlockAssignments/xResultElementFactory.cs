namespace Belien2007.A.E.O.Factories.ResultElements.Common.DaySurgeonNumberBlockAssignments
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Classes.ResultElements.Common.DaySurgeonNumberBlockAssignments;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ResultElements.Common.DaySurgeonNumberBlockAssignments;
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Common.DaySurgeonNumberBlockAssignments;

    internal sealed class xResultElementFactory : IxResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public xResultElementFactory()
        {
        }

        public IxResultElement Create(
            IiIndexElement iIndexElement,
            IsIndexElement sIndexElement,
            int value)
        {
            IxResultElement resultElement = null;

            try
            {
                resultElement = new xResultElement(
                    iIndexElement,
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