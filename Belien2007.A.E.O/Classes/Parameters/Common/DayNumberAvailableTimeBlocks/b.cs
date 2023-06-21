namespace Belien2007.A.E.O.Classes.Parameters.Common.DayNumberAvailableTimeBlocks
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.DayNumberAvailableTimeBlocks;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.DayNumberAvailableTimeBlocks;

    internal sealed class b : Ib
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public b(
            RedBlackTree<IiIndexElement, IbParameterElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IiIndexElement, IbParameterElement> Value { get; }

        public int GetElementAtAsint(
            IiIndexElement iIndexElement)
        {
            return this.Value[iIndexElement].Value.Value.Value;
        }
    }
}