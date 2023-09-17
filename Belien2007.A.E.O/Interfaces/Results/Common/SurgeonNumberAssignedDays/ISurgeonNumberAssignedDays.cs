namespace Belien2007.A.E.O.Interfaces.Results.Common.SurgeonNumberAssignedDays
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.ResultElements.Common.SurgeonNumberAssignedDays;
    using Belien2007.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface ISurgeonNumberAssignedDays
    {
        ImmutableList<ISurgeonNumberAssignedDaysResultElement> Value { get; }

        RedBlackTree<Organization, INullableValue<int>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}