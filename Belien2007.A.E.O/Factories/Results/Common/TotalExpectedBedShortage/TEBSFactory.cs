namespace Belien2007.A.E.O.Factories.Results.Common.TotalExpectedBedShortage
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Classes.Results.Common.TotalExpectedBedShortage;
    using Belien2007.A.E.O.Interfaces.Results.Common.TotalExpectedBedShortage;
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.TotalExpectedBedShortage;

    internal sealed class TEBSFactory : ITEBSFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TEBSFactory()
        {
        }

        public ITEBS Create(
            decimal value)
        {
            ITEBS result = null;

            try
            {
                result = new TEBS(
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