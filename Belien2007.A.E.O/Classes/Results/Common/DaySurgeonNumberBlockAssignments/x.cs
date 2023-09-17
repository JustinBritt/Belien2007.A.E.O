namespace Belien2007.A.E.O.Classes.Results.Common.DaySurgeonNumberBlockAssignments
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.Interfaces.ResultElements.Common.DaySurgeonNumberBlockAssignments;
    using Belien2007.A.E.O.Interfaces.Results.Common.DaySurgeonNumberBlockAssignments;
    using Belien2007.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class x : Ix
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public x(
            ImmutableList<IxResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IxResultElement> Value { get; }

        public int GetElementAtAsint(
            IiIndexElement iIndexElement,
            IsIndexElement sIndexElement)
        {
            return this.Value
                .Where(x => x.iIndexElement == iIndexElement && x.sIndexElement == sIndexElement)
                .Select(x => x.Value)
                .SingleOrDefault();
        }

        public RedBlackTree<FhirDateTime, RedBlackTree<Organization, INullableValue<int>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory,
            Ii i,
            Is s)
        {
            RedBlackTree<FhirDateTime, RedBlackTree<Organization, INullableValue<int>>> outerRedBlackTree = new RedBlackTree<FhirDateTime, RedBlackTree<Organization, INullableValue<int>>>();

            foreach (IiIndexElement iIndexElement in i.Value.Values)
            {
                RedBlackTree<Organization, INullableValue<int>> innerRedBlackTree = new RedBlackTree<Organization, INullableValue<int>>();

                foreach (IsIndexElement sIndexElement in s.Value.Values)
                {
                    innerRedBlackTree.Add(
                        sIndexElement.Value,
                        nullableValueFactory.Create<int>(
                            this.GetElementAtAsint(
                                iIndexElement,
                                sIndexElement)));
                }
            }

            return outerRedBlackTree;
        }
    }
}