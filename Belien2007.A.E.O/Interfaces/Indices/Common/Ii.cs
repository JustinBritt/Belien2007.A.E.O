namespace Belien2007.A.E.O.Interfaces.Indices.Common
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;

    public interface Ii
    {
        ImmutableList<IiIndexElement> Value { get; }

        IiIndexElement GetElementAt(
            int value);

        IiIndexElement GetElementAt(
            FhirDateTime value);

        int Getl();
    }
}