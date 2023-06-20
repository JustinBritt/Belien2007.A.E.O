namespace Belien2007.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.SurgeonMaximumNumberPatients;
    using Belien2007.A.E.O.InterfacesFactories.ParameterElements.Common.SurgeonMaximumNumberPatients;
    using Belien2007.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class SurgeonMaximumNumberPatientsVisitor<TKey, TValue> : ISurgeonMaximumNumberPatientsVisitor<TKey, TValue>
        where TKey : Organization
        where TValue : INullableValue<int>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonMaximumNumberPatientsVisitor(
            ICommonnParameterElementFactory commonnParameterElementFactory,
            Is s)
        {
            this.commonnParameterElementFactory = commonnParameterElementFactory;

            this.s = s;
        }

        private ICommonnParameterElementFactory commonnParameterElementFactory { get; }

        private Is s { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IsIndexElement, ICommonnParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IsIndexElement sIndexElement = this.s.GetElementAt(
                obj.Key);

            this.RedBlackTree.Add(
                sIndexElement,
                this.commonnParameterElementFactory.Create(
                    sIndexElement,
                    obj.Value));
        }
    }
}