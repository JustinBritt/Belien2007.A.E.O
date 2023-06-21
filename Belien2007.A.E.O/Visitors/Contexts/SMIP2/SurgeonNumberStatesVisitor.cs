namespace Belien2007.A.E.O.Visitors.Contexts.SMIP2
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Stochastic.SurgeonNumberStates;
    using Belien2007.A.E.O.InterfacesFactories.ParameterElements.Stochastic.SurgeonNumberStates;
    using Belien2007.A.E.O.InterfacesVisitors.Contexts.SMIP2;

    internal sealed class SurgeonNumberStatesVisitor<TKey, TValue> : ISurgeonNumberStatesVisitor<TKey, TValue>
        where TKey : Organization
        where TValue : INullableValue<int>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonNumberStatesVisitor(
            IqParameterElementFactory qParameterElementFactory,
            Is s)
        {
            this.qParameterElementFactory = qParameterElementFactory;

            this.s = s;

            this.RedBlackTree = new RedBlackTree<IsIndexElement, IqParameterElement>();
        }

        private IqParameterElementFactory qParameterElementFactory { get; }

        private Is s { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IsIndexElement, IqParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IsIndexElement sIndexElement = this.s.GetElementAt(
                obj.Key);

            this.RedBlackTree.Add(
                sIndexElement,
                this.qParameterElementFactory.Create(
                    sIndexElement,
                    obj.Value));
        }
    }
}