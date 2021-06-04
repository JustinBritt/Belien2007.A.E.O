namespace Belien2007.A.E.O.Factories.Results.Common.DaySurgeonNumberBlockAssignments
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Belien2007.A.E.O.Classes.Results.Common.DaySurgeonNumberBlockAssignments;
    using Belien2007.A.E.O.Interfaces.ResultElements.Common.DaySurgeonNumberBlockAssignments;
    using Belien2007.A.E.O.Interfaces.Results.Common.DaySurgeonNumberBlockAssignments;
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.DaySurgeonNumberBlockAssignments;

    internal sealed class xFactory : IxFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public xFactory()
        {
        }

        public Ix Create(
            ImmutableList<IxResultElement> value)
        {
            Ix result = null;

            try
            {
                result = new x(
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