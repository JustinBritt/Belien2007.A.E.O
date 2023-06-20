namespace Belien2007.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.SurgeonLengthOfStayMaximums;
    using Belien2007.A.E.O.InterfacesFactories.ParameterElements.Common.SurgeonLengthOfStayMaximums;
    using Belien2007.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class SurgeonLengthOfStayMaximumsVisitor<TKey, TValue> : ISurgeonLengthOfStayMaximumsVisitor<TKey, TValue>
        where TKey : Organization
        where TValue : INullableValue<int>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonLengthOfStayMaximumsVisitor(
            ImParameterElementFactory mParameterElementFactory,
            Is s)
        {
            this.mParameterElementFactory = mParameterElementFactory;

            this.s = s;

            this.RedBlackTree = new RedBlackTree<IsIndexElement, ImParameterElement>();
        }

        private ImParameterElementFactory mParameterElementFactory { get; }

        private Is s { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IsIndexElement, ImParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IsIndexElement sIndexElement = this.s.GetElementAt(
                obj.Key);

            this.RedBlackTree.Add(
                sIndexElement,
                this.mParameterElementFactory.Create(
                    sIndexElement,
                    obj.Value));
        }
    }
}