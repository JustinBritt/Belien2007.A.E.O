namespace Belien2007.A.E.O.InterfacesFactories.Results.Common.DayExpectedBedShortages
{
    using System.Collections.Immutable;

    using Belien2007.A.E.O.Interfaces.ResultElements.Common.DayExpectedBedShortages;
    using Belien2007.A.E.O.Interfaces.Results.Common.DayExpectedBedShortages;

    public interface IEBSFactory
    {
        IEBS Create(
            ImmutableList<IEBSResultElement> value);
    }
}