namespace Belien2007.A.E.O.Classes.Parameters.Common.DayBedCapacities
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.DayBedCapacities;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.DayBedCapacities;

    internal sealed class c : Ic
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public c(
            RedBlackTree<IiIndexElement, IcParameterElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IiIndexElement, IcParameterElement> Value { get; }

        public int GetElementAtAsint(
            IiIndexElement iIndexElement)
        {
            return this.Value[iIndexElement].Value.Value.Value;
        }
    }
}