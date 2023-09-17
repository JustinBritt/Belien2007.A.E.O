namespace Belien2007.A.E.O.Interfaces.Results.Stochastic.SurgeonStateNumberPatients
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Stochastic;
    using Belien2007.A.E.O.Interfaces.ResultElements.Stochastic.SurgeonStateNumberPatients;
    using Belien2007.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface ISurgeonStateNumberPatients
    {
        ImmutableList<ISurgeonStateNumberPatientsResultElement> Value { get; }

        RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory,
            Ik k,
            Is s);
    }
}