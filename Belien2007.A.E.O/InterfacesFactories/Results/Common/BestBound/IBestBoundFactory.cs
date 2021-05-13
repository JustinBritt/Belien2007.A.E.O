namespace Belien2007.A.E.O.InterfacesFactories.Results.Common.BestBound
{
    using Belien2007.A.E.O.Interfaces.Results.Common.BestBound;

    public interface IBestBoundFactory
    {
        IBestBound Create(
            decimal value);
    }
}