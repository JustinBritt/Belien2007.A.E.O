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
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.InterfacesFactories.Indices.Common;

    internal sealed class d2Factory : Id2Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d2Factory()
        {
        }

        public Id2 Create(
            INullableValueintComparer nullableValueintComparer,
            ImmutableList<Id2IndexElement> value)
        {
            Id2 index = null;

            try
            {
                index = new d2(
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

        private RedBlackTree<INullableValue<int>, Id2IndexElement> CreateRedBlackTree(
            INullableValueintComparer nullableValueintComparer,
            ImmutableList<Id2IndexElement> value)
        {
            RedBlackTree<INullableValue<int>, Id2IndexElement> redBlackTree = new RedBlackTree<INullableValue<int>, Id2IndexElement>(
                nullableValueintComparer);

            foreach (Id2IndexElement d2IndexElement in value)
            {
                redBlackTree.Add(
                    d2IndexElement.Value,
                    d2IndexElement);
            }

            return redBlackTree;
        }
    }
}