namespace Belien2007.A.E.O.Visitors.Contexts.Common
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.DayBedCapacities;
    using Belien2007.A.E.O.InterfacesFactories.ParameterElements.Common.DayBedCapacities;
    using Belien2007.A.E.O.InterfacesVisitors.Contexts.Common;

    internal sealed class DayBedCapacitiesVisitor<TKey, TValue> : IDayBedCapacitiesVisitor<TKey, TValue>
        where TKey : FhirDateTime
        where TValue : INullableValue<int>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DayBedCapacitiesVisitor(
            IcParameterElementFactory cParameterElementFactory,
            Ii i)
        {
            this.cParameterElementFactory = cParameterElementFactory;

            this.i = i;

            this.RedBlackTree = new RedBlackTree<IiIndexElement, IcParameterElement>();
        }

        private IcParameterElementFactory cParameterElementFactory { get; }

        private Ii i { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IiIndexElement, IcParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IiIndexElement iIndexElement = this.i.GetElementAt(
                obj.Key);

            this.RedBlackTree.Add(
                iIndexElement,
                this.cParameterElementFactory.Create(
                    iIndexElement,
                    obj.Value));
        }
    }
}