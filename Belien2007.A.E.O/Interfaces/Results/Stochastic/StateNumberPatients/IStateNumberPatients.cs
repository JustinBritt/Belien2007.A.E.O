namespace Belien2007.A.E.O.Interfaces.Results.Stochastic.StateNumberPatients
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.ResultElements.Stochastic.StateNumberPatients;
    using Belien2007.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface IStateNumberPatients
    {
        ImmutableList<IStateNumberPatientsResultElement> Value { get; }

        RedBlackTree<INullableValue<int>, INullableValue<int>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}