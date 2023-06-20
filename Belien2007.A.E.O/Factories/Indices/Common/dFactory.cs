namespace Belien2007.A.E.O.Factories.Indices.Common
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Classes.Indices.Common;
    using Belien2007.A.E.O.Interfaces.Comparers;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.InterfacesFactories.Indices.Common;

    internal sealed class dFactory : IdFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public dFactory()
        {
        }

        public Belien2007.A.E.O.Interfaces.Indices.Common.Id Create(
            INullableValueintComparer nullableValueintComparer,
            ImmutableList<IdIndexElement> value)
        {
            Belien2007.A.E.O.Interfaces.Indices.Common.Id index = null;

            try
            {
                index = new d(
                    this.CreateRedBlackTree(
                        nullableValueintComparer,
                        value));
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return index;
        }

        private RedBlackTree<INullableValue<int>, IdIndexElement> CreateRedBlackTree(
            INullableValueintComparer nullableValueintComparer,
            ImmutableList<IdIndexElement> value)
        {
            RedBlackTree<INullableValue<int>, IdIndexElement> redBlackTree = new RedBlackTree<INullableValue<int>, IdIndexElement>(
                nullableValueintComparer);

            foreach (IdIndexElement dIndexElement in value)
            {
                redBlackTree.Add(
                    dIndexElement.Value,
                    dIndexElement);
            }

            return redBlackTree;
        }
    }
}