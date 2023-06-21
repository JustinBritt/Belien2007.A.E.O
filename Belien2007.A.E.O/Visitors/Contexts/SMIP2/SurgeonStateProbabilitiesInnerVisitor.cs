namespace Belien2007.A.E.O.Visitors.Contexts.SMIP2
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;
    using Belien2007.A.E.O.Interfaces.Indices.Stochastic;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Stochastic.SurgeonStateProbabilities;
    using Belien2007.A.E.O.InterfacesFactories.ParameterElements.Stochastic.SurgeonStateProbabilities;
    using Belien2007.A.E.O.InterfacesVisitors.Contexts.SMIP2;

    internal sealed class SurgeonStateProbabilitiesInnerVisitor<TKey, TValue> : ISurgeonStateProbabilitiesInnerVisitor<TKey, TValue>
        where TKey : INullableValue<int>
        where TValue : INullableValue<decimal>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonStateProbabilitiesInnerVisitor(
            IhParameterElementFactory hParameterElementFactory,
            IsIndexElement sIndexElement,
            Ik k)
        {
            this.hParameterElementFactory = hParameterElementFactory;

            this.sIndexElement = sIndexElement;

            this.k = k;

            this.RedBlackTree = new RedBlackTree<IkIndexElement, IhParameterElement>();
        }

        private IhParameterElementFactory hParameterElementFactory { get; }

        private IsIndexElement sIndexElement { get; }

        private Ik k { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IkIndexElement, IhParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IkIndexElement kIndexElement = this.k.GetElementAt(
                obj.Key);

            this.RedBlackTree.Add(
                kIndexElement,
                this.hParameterElementFactory.Create(
                    this.sIndexElement,
                    kIndexElement,
                    obj.Value));
        }
    }
}