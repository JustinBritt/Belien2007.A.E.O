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
    
    internal sealed class d1Factory : Id1Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d1Factory()
        {
        }

        public Id1 Create(
            INullableValueintComparer nullableValueintComparer,
            ImmutableList<Id1IndexElement> value)
        {
            Id1 index = null;

            try
            {
                index = new d1(
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

        private RedBlackTree<INullableValue<int>, Id1IndexElement> CreateRedBlackTree(
            INullableValueintComparer nullableValueintComparer,
            ImmutableList<Id1IndexElement> value)
        {
            RedBlackTree<INullableValue<int>, Id1IndexElement> redBlackTree = new RedBlackTree<INullableValue<int>, Id1IndexElement>(
                nullableValueintComparer);

            foreach (Id1IndexElement d1IndexElement in value)
            {
                redBlackTree.Add(
                    d1IndexElement.Value,
                    d1IndexElement);
            }

            return redBlackTree;
        }
    }
}