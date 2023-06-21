namespace Belien2007.A.E.O.Classes.Parameters.Stochastic.SurgeonNumberStates
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Stochastic.SurgeonNumberStates;
    using Belien2007.A.E.O.Interfaces.Parameters.Stochastic.SurgeonNumberStates;

    internal sealed class q : Iq
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public q(
            RedBlackTree<IsIndexElement, IqParameterElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IsIndexElement, IqParameterElement> Value { get; }

        public int GetElementAtAsint(
            IsIndexElement sIndexElement)
        {
            return this.Value[sIndexElement].Value.Value.Value;
        }
    }
}