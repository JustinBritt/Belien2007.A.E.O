namespace Belien2007.A.E.O.Interfaces.Indices.Common
{
    using System.Collections.Immutable;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;

    public interface Id1
    {
        ImmutableList<Id1IndexElement> Value { get; }
    }
}