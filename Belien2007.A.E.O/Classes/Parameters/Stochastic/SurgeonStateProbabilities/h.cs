namespace Belien2007.A.E.O.Classes.Parameters.Stochastic.SurgeonStateProbabilities
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Stochastic.SurgeonStateProbabilities;
    using Belien2007.A.E.O.Interfaces.Parameters.Stochastic.SurgeonStateProbabilities;

    internal sealed class h : Ih
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public h(
            RedBlackTree<IsIndexElement, RedBlackTree<IkIndexElement, IhParameterElement>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IsIndexElement, RedBlackTree<IkIndexElement, IhParameterElement>> Value { get; }

        public decimal GetElementAtAsdecimal(
            IsIndexElement sIndexElement,
            IkIndexElement kIndexElement)
        {
            return this.Value[sIndexElement][kIndexElement].Value.Value.Value;
        }
    }
}