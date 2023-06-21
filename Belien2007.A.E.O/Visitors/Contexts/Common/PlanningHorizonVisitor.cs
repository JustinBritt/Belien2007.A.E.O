namespace Belien2007.A.E.O.Visitors.Contexts.Common
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.Comparers;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.InterfacesFactories.IndexElements.Common;
    using Belien2007.A.E.O.InterfacesVisitors.Contexts.Common;

    internal sealed class PlanningHorizonVisitor<TKey, TValue> : IPlanningHorizonVisitor<TKey, TValue>
        where TKey : INullableValue<int>
        where TValue : FhirDateTime
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public PlanningHorizonVisitor(
            IiIndexElementFactory iIndexElementFactory,
            IjIndexElementFactory jIndexElementFactory,
            IFhirDateTimeComparer FhirDateTimeComparer)
        {
            this.iIndexElementFactory = iIndexElementFactory;

            this.jIndexElementFactory = jIndexElementFactory;

            this.iRedBlackTree = new RedBlackTree<FhirDateTime, IiIndexElement>(
                FhirDateTimeComparer);

            this.jRedBlackTree = new RedBlackTree<FhirDateTime, IjIndexElement>(
                FhirDateTimeComparer);
        }

        private IiIndexElementFactory iIndexElementFactory { get; }

        private IjIndexElementFactory jIndexElementFactory { get; }

        public bool HasCompleted => false;

        public RedBlackTree<FhirDateTime, IiIndexElement> iRedBlackTree { get; }

        public RedBlackTree<FhirDateTime, IjIndexElement> jRedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            this.iRedBlackTree.Add(
                obj.Value,
                this.iIndexElementFactory.Create(
                    obj.Key.Value.Value,
                    obj.Value));

            this.jRedBlackTree.Add(
                obj.Value,
                this.jIndexElementFactory.Create(
                    obj.Key.Value.Value,
                    obj.Value));
        }
    }
}