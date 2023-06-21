namespace Belien2007.A.E.O.Factories.Parameters.Common.DayNumberAvailableTimeBlocks
{
    using System;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Classes.Parameters.Common.DayNumberAvailableTimeBlocks;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.DayNumberAvailableTimeBlocks;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.DayNumberAvailableTimeBlocks;
    using Belien2007.A.E.O.InterfacesFactories.Parameters.Common.DayNumberAvailableTimeBlocks;

    internal sealed class bFactory : IbFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public bFactory()
        {
        }

        public Ib Create(
            RedBlackTree<IiIndexElement, IbParameterElement> value)
        {
            Ib parameter = null;

            try
            {
                parameter = new b(
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