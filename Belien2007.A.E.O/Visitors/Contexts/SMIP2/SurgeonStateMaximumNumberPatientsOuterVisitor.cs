namespace Belien2007.A.E.O.Visitors.Contexts.SMIP2
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
    using Belien2007.A.E.O.Interfaces.ParameterElements.Stochastic.SurgeonStateMaximumNumberPatients;
    using Belien2007.A.E.O.InterfacesFactories.ParameterElements.Stochastic.SurgeonStateMaximumNumberPatients;
    using Belien2007.A.E.O.InterfacesVisitors.Contexts.SMIP2;

    internal sealed class SurgeonStateMaximumNumberPatientsOuterVisitor<TKey, TValue> : ISurgeonStateMaximumNumberPatientsOuterVisitor<TKey, TValue>
        where TKey : Organization
        where TValue : RedBlackTree<INullableValue<int>, INullableValue<int>>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonStateMaximumNumberPatientsOuterVisitor(
            IStochasticnParameterElementFactory stochasticnParameterElementFactory,
            Ik k,
            Is s)
        {
            this.stochasticnParameterElementFactory = stochasticnParameterElementFactory;

            this.k = k;

            this.s = s;

            this.RedBlackTree = new RedBlackTree<IsIndexElement, RedBlackTree<IkIndexElement, IStochasticnParameterElement>>();
        }

        private IStochasticnParameterElementFactory stochasticnParameterElementFactory { get; }

        private Ik k { get; }

        private Is s { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IsIndexElement, RedBlackTree<IkIndexElement, IStochasticnParameterElement>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IsIndexElement sIndexElement = this.s.GetElementAt(
                obj.Key);

            RedBlackTree<INullableValue<int>, INullableValue<int>> value = obj.Value;

            var innerVisitor = new SurgeonStateMaximumNumberPatientsInnerVisitor<INullableValue<int>, INullableValue<int>>(
                this.stochasticnParameterElementFactory,
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