namespace Belien2007.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Stochastic;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Stochastic.SurgeonStateProbabilities;
    using Belien2007.A.E.O.InterfacesFactories.ParameterElements.Stochastic.SurgeonStateProbabilities;
    using Belien2007.A.E.O.InterfacesVisitors.Contexts;
   
    internal sealed class SurgeonStateProbabilitiesOuterVisitor<TKey, TValue> : ISurgeonStateProbabilitiesOuterVisitor<TKey, TValue>
        where TKey : Organization
        where TValue : RedBlackTree<INullableValue<int>, INullableValue<decimal>>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonStateProbabilitiesOuterVisitor(
            IhParameterElementFactory hParameterElementFactory,
            Ik k,
            Is s)
        {
            this.hParameterElementFactory = hParameterElementFactory;

            this.k = k;

            this.s = s;

            this.RedBlackTree = new RedBlackTree<IsIndexElement, RedBlackTree<IkIndexElement, IhParameterElement>>();
        }

        private IhParameterElementFactory hParameterElementFactory { get; }

        private Ik k { get; }

        private Is s { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IsIndexElement, RedBlackTree<IkIndexElement, IhParameterElement>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IsIndexElement sIndexElement = this.s.GetElementAt(
                obj.Key);

            RedBlackTree<INullableValue<int>, INullableValue<decimal>> value = obj.Value;

            var innerVisitor = new SurgeonStateProbabilitiesInnerVisitor<INullableValue<int>, INullableValue<decimal>>(
                this.hParameterElementFactory,
                sIndexElement,
                this.k);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                sIndexElement,
                innerVisitor.RedBlackTree);
        }
    }
}