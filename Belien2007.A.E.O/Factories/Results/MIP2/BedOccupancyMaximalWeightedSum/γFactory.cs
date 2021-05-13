namespace Belien2007.A.E.O.Factories.Results.MIP2.BedOccupancyMaximalWeightedSum
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Classes.Results.MIP2.BedOccupancyMaximalWeightedSum;
    using Belien2007.A.E.O.Interfaces.Results.MIP2.BedOccupancyMaximalWeightedSum;
    using Belien2007.A.E.O.InterfacesFactories.Results.MIP2.BedOccupancyMaximalWeightedSum;

    internal sealed class γFactory : IγFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public γFactory()
        {
        }

        public Iγ Create(
            decimal value)
        {
            Iγ result = null;

            try
            {
                result = new γ(
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