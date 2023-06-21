namespace Belien2007.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;
    using Belien2007.A.E.O.Interfaces.Indices.Stochastic;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Stochastic.SurgeonStateMaximumNumberPatients;
    using Belien2007.A.E.O.InterfacesFactories.ParameterElements.Stochastic.SurgeonStateMaximumNumberPatients;
    using Belien2007.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class SurgeonStateMaximumNumberPatientsInnerVisitor<TKey, TValue> : ISurgeonStateMaximumNumberPatientsInnerVisitor<TKey, TValue>
        where TKey : INullableValue<int>
        where TValue : INullableValue<int>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonStateMaximumNumberPatientsInnerVisitor(
            IStochasticnParameterElementFactory stochasticnParameterElementFactory,
            IsIndexElement sIndexElement,
            Ik k)
        {
            this.stochasticnParameterElementFactory = stochasticnParameterElementFactory;

            this.sIndexElement = sIndexElement;

            this.k = k;

            this.RedBlackTree = new RedBlackTree<IkIndexElement, IStochasticnParameterElement>();
        }
        
        private IStochasticnParameterElementFactory stochasticnParameterElementFactory { get; }

        private IsIndexElement sIndexElement { get; }

        private Ik k { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IkIndexElement, IStochasticnParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IkIndexElement kIndexElement = this.k.GetElementAt(
                obj.Key);

            this.RedBlackTree.Add(
                kIndexElement,
                this.stochasticnParameterElementFactory.Create(
                    this.sIndexElement,
                    kIndexElement,
                    obj.Value));
        }
    }
}