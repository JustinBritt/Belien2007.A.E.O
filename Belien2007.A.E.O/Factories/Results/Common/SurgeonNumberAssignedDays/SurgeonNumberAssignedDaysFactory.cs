namespace Belien2007.A.E.O.Factories.Results.Common.SurgeonNumberAssignedDays
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Belien2007.A.E.O.Classes.Results.Common.SurgeonNumberAssignedDays;
    using Belien2007.A.E.O.Interfaces.ResultElements.Common.SurgeonNumberAssignedDays;
    using Belien2007.A.E.O.Interfaces.Results.Common.SurgeonNumberAssignedDays;
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.SurgeonNumberAssignedDays;

    internal sealed class SurgeonNumberAssignedDaysFactory : ISurgeonNumberAssignedDaysFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonNumberAssignedDaysFactory()
        {
        }

        public ISurgeonNumberAssignedDays Create(
            ImmutableList<ISurgeonNumberAssignedDaysResultElement> value)
        {
            ISurgeonNumberAssignedDays result = null;

            try
            {
                result = new SurgeonNumberAssignedDays(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return result;
        }
    }
}