namespace Belien2007.A.E.O.Factories.Parameters.Common.SurgeonNumberTimeBlocks
{
    using System;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Classes.Parameters.Common.SurgeonNumberTimeBlocks;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.SurgeonNumberTimeBlocks;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonNumberTimeBlocks;
    using Belien2007.A.E.O.InterfacesFactories.Parameters.Common.SurgeonNumberTimeBlocks;

    internal sealed class rFactory : IrFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public rFactory()
        {
        }

        public Ir Create(
            RedBlackTree<IsIndexElement, IrParameterElement> value)
        {
            Ir parameter = null;

            try
            {
                parameter = new r(
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