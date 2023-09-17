namespace Belien2007.A.E.O.Classes.Results.Common.SurgeonNumberAssignedDays
{
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.ResultElements.Common.SurgeonNumberAssignedDays;
    using Belien2007.A.E.O.Interfaces.Results.Common.SurgeonNumberAssignedDays;
    using Belien2007.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class SurgeonNumberAssignedDays : ISurgeonNumberAssignedDays
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonNumberAssignedDays(
            ImmutableList<ISurgeonNumberAssignedDaysResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<ISurgeonNumberAssignedDaysResultElement> Value { get; }

        public RedBlackTree<Organization, INullableValue<int>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            RedBlackTree<Organization, INullableValue<int>> redBlackTree = new RedBlackTree<Organization, INullableValue<int>>(
                new Belien2007.A.E.O.Classes.Comparers.OrganizationComparer());

            foreach (ISurgeonNumberAssignedDaysResultElement surgeonNumberAssignedDaysResultElement in this.Value)
            {
                redBlackTree.Add(
                    surgeonNumberAssignedDaysResultElement.sIndexElement.Value,
                    nullableValueFactory.Create<int>(
                        surgeonNumberAssignedDaysResultElement.Value));
            }

            return redBlackTree;
        }
    }
}