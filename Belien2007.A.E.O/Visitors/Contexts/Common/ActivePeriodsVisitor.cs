namespace Belien2007.A.E.O.Visitors.Contexts.Common
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.ActivePeriods;
    using Belien2007.A.E.O.InterfacesFactories.ParameterElements.Common.ActivePeriods;
    using Belien2007.A.E.O.InterfacesVisitors.Contexts.Common;

    internal sealed class ActivePeriodsVisitor<TKey, TValue> : IActivePeriodsVisitor<TKey, TValue>
        where TKey : FhirDateTime
        where TValue : INullableValue<bool>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ActivePeriodsVisitor(
            IAParameterElementFactory AParameterElementFactory,
            Ii i)
        {
            this.AParameterElementFactory = AParameterElementFactory;

            this.i = i;

            this.RedBlackTree = new RedBlackTree<IiIndexElement, IAParameterElement>();
        }

        private IAParameterElementFactory AParameterElementFactory { get; }

        private Ii i { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IiIndexElement, IAParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IiIndexElement iIndexElement = this.i.GetElementAt(
                obj.Key);

            this.RedBlackTree.Add(
                iIndexElement,
                this.AParameterElementFactory.Create(
                    iIndexElement,
                    obj.Value));
        }
    }
}