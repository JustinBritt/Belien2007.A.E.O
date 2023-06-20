namespace Belien2007.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.SurgeonDayLengthOfStayProbabilities;
    using Belien2007.A.E.O.InterfacesFactories.ParameterElements.Common.SurgeonDayLengthOfStayProbabilities;
    using Belien2007.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class SurgeonDayLengthOfStayProbabilitiesInnerVisitor<TKey, TValue> : ISurgeonDayLengthOfStayProbabilitiesInnerVisitor<TKey, TValue>
        where TKey : INullableValue<int>
        where TValue : INullableValue<decimal>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonDayLengthOfStayProbabilitiesInnerVisitor(
            IpParameterElementFactory pParameterElementFactory,
            IsIndexElement sIndexElement,
            Belien2007.A.E.O.Interfaces.Indices.Common.Id d)
        {
            this.pParameterElementFactory = pParameterElementFactory;

            this.sIndexElement = sIndexElement;

            this.d = d;

            this.RedBlackTree = new RedBlackTree<IdIndexElement, IpParameterElement>();
        }

        private IpParameterElementFactory pParameterElementFactory { get; }

        private IsIndexElement sIndexElement { get; }

        private Belien2007.A.E.O.Interfaces.Indices.Common.Id d { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IdIndexElement, IpParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IdIndexElement dIndexElement = this.d.GetElementAt(
                obj.Key);

            this.RedBlackTree.Add(
                dIndexElement,
                this.pParameterElementFactory.Create(
                    this.sIndexElement,
                    dIndexElement,
                    obj.Value));
        }
    }
}