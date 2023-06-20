namespace Belien2007.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.DayNumberAvailableTimeBlocks;
    using Belien2007.A.E.O.InterfacesFactories.ParameterElements.Common.DayNumberAvailableTimeBlocks;
    using Belien2007.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class DayNumberTimeBlocksVisitor<TKey, TValue> : IDayNumberTimeBlocksVisitor<TKey, TValue>
        where TKey : FhirDateTime
        where TValue : INullableValue<int>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DayNumberTimeBlocksVisitor(
            IbParameterElementFactory bParameterElementFactory,
            Ii i)
        {
            this.bParameterElementFactory = bParameterElementFactory;

            this.i = i;
        }

        private IbParameterElementFactory bParameterElementFactory { get; }

        private Ii i { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IiIndexElement, IbParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IiIndexElement iIndexElement = this.i.GetElementAt(
                obj.Key);

            this.RedBlackTree.Add(
                iIndexElement,
                this.bParameterElementFactory.Create(
                    iIndexElement,
                    obj.Value));
        }
    }
}