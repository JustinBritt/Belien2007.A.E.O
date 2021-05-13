namespace Belien2007.A.E.O.Interfaces.CrossJoins.Common
{
    using System.Collections.Immutable;

    using Belien2007.A.E.O.Interfaces.CrossJoinElements.Common;

    public interface Id1d2
    {
        ImmutableList<Id1d2CrossJoinElement> Value { get; }
    }
}