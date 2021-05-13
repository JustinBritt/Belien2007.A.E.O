namespace Belien2007.A.E.O.Interfaces.Indices.Common
{
    using System.Collections.Immutable;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;

    public interface Id2
    {
        ImmutableList<Id2IndexElement> Value { get; }
    }
}