namespace Belien2007.A.E.O.InterfacesFactories.Results.Common.TotalExpectedBedShortage
{
    using Belien2007.A.E.O.Interfaces.Results.Common.TotalExpectedBedShortage;

    public interface ITEBSFactory
    {
        ITEBS Create(
            decimal value);
    }
}