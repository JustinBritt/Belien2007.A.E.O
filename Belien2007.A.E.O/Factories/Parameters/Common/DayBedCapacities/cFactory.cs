namespace Belien2007.A.E.O.Factories.Parameters.Common.DayBedCapacities
{
    using System;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Classes.Parameters.Common.DayBedCapacities;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.DayBedCapacities;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.DayBedCapacities;
    using Belien2007.A.E.O.InterfacesFactories.Parameters.Common.DayBedCapacities;

    internal sealed class cFactory : IcFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public cFactory()
        {
        }

        public Ic Create(
            RedBlackTree<IiIndexElement, IcParameterElement> value)
        {
            Ic parameter = null;

            try
            {
                parameter = new c(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameter;
        }
    }
}