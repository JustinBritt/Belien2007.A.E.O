namespace Belien2007.A.E.O.Visitors.Contexts.Common
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.SurgeonDayLengthOfStayProbabilities;
    using Belien2007.A.E.O.InterfacesFactories.ParameterElements.Common.SurgeonDayLengthOfStayProbabilities;
    using Belien2007.A.E.O.InterfacesVisitors.Contexts.Common;
    
    internal sealed class SurgeonDayLengthOfStayProbabilitiesOuterVisitor<TKey, TValue> : ISurgeonDayLengthOfStayProbabilitiesOuterVisitor<TKey, TValue>
        where TKey : Organization
        where TValue : RedBlackTree<INullableValue<int>, INullableValue<decimal>>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonDayLengthOfStayProbabilitiesOuterVisitor(
            IpParameterElementFactory pParameterElementFactory,
            Belien2007.A.E.O.Interfaces.Indices.Common.Id d,
            Is s)
        {
            this.pParameterElementFactory = pParameterElementFactory;

            this.d = d;

            this.s = s;

            this.RedBlackTree = new RedBlackTree<IsIndexElement, RedBlackTree<IdIndexElement, IpParameterElement>>();
        }

        private IpParameterElementFactory pParameterElementFactory { get; }

        private Belien2007.A.E.O.Interfaces.Indices.Common.Id d { get; }

        private Is s { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IsIndexElement, RedBlackTree<IdIndexElement, IpParameterElement>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IsIndexElement sIndexElement = this.s.GetElementAt(
                obj.Key);

            RedBlackTree<INullableValue<int>, INullableValue<decimal>> value = obj.Value;

            var innerVisitor = new SurgeonDayLengthOfStayProbabilitiesInnerVisitor<INullableValue<int>, INullableValue<decimal>>(
                this.pParameterElementFactory,
                sIndexElement,
                this.d);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                sIndexElement,
                innerVisitor.RedBlackTree);
        }
    }
}