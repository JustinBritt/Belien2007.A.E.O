namespace Belien2007.A.E.O.InterfacesFactories.CrossJoins.Common
{
    using System.Collections.Immutable;

    using Belien2007.A.E.O.Interfaces.CrossJoinElements.Common;
    using Belien2007.A.E.O.Interfaces.CrossJoins.Common;

    public interface IsjdFactory
    {
        Isjd Create(
            ImmutableList<IsjdCrossJoinElement> value);
    }
}