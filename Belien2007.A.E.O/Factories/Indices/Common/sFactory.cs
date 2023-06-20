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

    internal sealed class sFactory : IsFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public sFactory()
        {
        }

        public Is Create(
            IOrganizationComparer organizationComparer,
            ImmutableList<IsIndexElement> value)
        {
            Is index = null;

            try
            {
                index = new s(
                    this.CreateRedBlackTree(
                        organizationComparer,
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

        private RedBlackTree<Organization, IsIndexElement> CreateRedBlackTree(
            IOrganizationComparer organizationComparer,
            ImmutableList<IsIndexElement> value)
        {
            RedBlackTree<Organization, IsIndexElement> redBlackTree = new RedBlackTree<Organization, IsIndexElement>(
                organizationComparer);

            foreach (IsIndexElement sIndexElement in value)
            {
                redBlackTree.Add(
                    sIndexElement.Value,
                    sIndexElement);
            }

            return redBlackTree;
        }
    }
}