namespace Belien2007.A.E.O.Classes.Parameters.Stochastic.SurgeonStateMaximumNumberPatients
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Stochastic.SurgeonStateMaximumNumberPatients;
    using Belien2007.A.E.O.Interfaces.Parameters.Stochastic.SurgeonStateMaximumNumberPatients;

    internal sealed class Stochasticn : IStochasticn
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Stochasticn(
            RedBlackTree<IsIndexElement, RedBlackTree<IkIndexElement, IStochasticnParameterElement>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IsIndexElement, RedBlackTree<IkIndexElement, IStochasticnParameterElement>> Value { get; }

        public int GetElementAtAsint(
            IsIndexElement sIndexElement,
            IkIndexElement kIndexElement)
        {
            return this.Value[sIndexElement][kIndexElement].Value.Value.Value;
        }
    }
}