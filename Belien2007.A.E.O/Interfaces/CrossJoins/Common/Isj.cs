namespace Belien2007.A.E.O.Interfaces.CrossJoins.Common
{
    using System.Collections.Immutable;

    using Belien2007.A.E.O.Interfaces.CrossJoinElements.Common;

    public interface Isj
    {
        ImmutableList<IsjCrossJoinElement> Value { get; }
    }
}