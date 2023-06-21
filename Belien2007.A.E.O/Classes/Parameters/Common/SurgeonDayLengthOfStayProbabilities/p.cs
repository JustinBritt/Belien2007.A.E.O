namespace Belien2007.A.E.O.Classes.Parameters.Common.SurgeonDayLengthOfStayProbabilities
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.SurgeonDayLengthOfStayProbabilities;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonDayLengthOfStayProbabilities;

    internal sealed class p : Ip
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public p(
            RedBlackTree<IsIndexElement, RedBlackTree<IdIndexElement, IpParameterElement>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IsIndexElement, RedBlackTree<IdIndexElement, IpParameterElement>> Value { get; }

        public decimal GetElementAtAsdecimal(
            IsIndexElement sIndexElement,
            IdIndexElement dIndexElement)
        {
            return this.Value[sIndexElement][dIndexElement].Value.Value.Value;
        }
    }
}