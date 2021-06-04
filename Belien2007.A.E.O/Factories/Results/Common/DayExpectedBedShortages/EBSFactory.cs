namespace Belien2007.A.E.O.Factories.Results.Common.DayExpectedBedShortages
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Belien2007.A.E.O.Classes.Results.Common.DayExpectedBedShortages;
    using Belien2007.A.E.O.Interfaces.ResultElements.Common.DayExpectedBedShortages;
    using Belien2007.A.E.O.Interfaces.Results.Common.DayExpectedBedShortages;
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.DayExpectedBedShortages;

    internal sealed class EBSFactory : IEBSFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public EBSFactory()
        {
        }

        public IEBS Create(
            ImmutableList<IEBSResultElement> value)
        {
            IEBS result = null;

            try
            {
                result = new EBS(
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