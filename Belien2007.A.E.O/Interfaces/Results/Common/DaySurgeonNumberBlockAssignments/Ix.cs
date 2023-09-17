namespace Belien2007.A.E.O.Interfaces.Results.Common.DaySurgeonNumberBlockAssignments
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.Interfaces.ResultElements.Common.DaySurgeonNumberBlockAssignments;
    using Belien2007.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface Ix
    {
        ImmutableList<IxResultElement> Value { get; }

        int GetElementAtAsint(
            IiIndexElement iIndexElement,
            IsIndexElement sIndexElement);

        RedBlackTree<FhirDateTime, RedBlackTree<Organization, INullableValue<int>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory,
            Ii i,
            Is s);
    }
}