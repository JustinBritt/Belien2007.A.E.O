namespace Belien2007.A.E.O.Interfaces.Calculations.Common.TotalExpectedBedShortage
{
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.Interfaces.Results.Common.DayExpectedBedShortages;
    using Belien2007.A.E.O.Interfaces.Results.Common.TotalExpectedBedShortage;
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.TotalExpectedBedShortage;

    public interface ITEBSCalculation
    {
        ITEBS Calculate(
            ITEBSFactory TEBSFactory,
            Ii i,
            IEBS EBS);
    }
}