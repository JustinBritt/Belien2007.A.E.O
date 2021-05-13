namespace Belien2007.A.E.O.InterfacesAbstractFactories
{
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.BestBound;
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.DayBedOccupancyMeans;
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.DayBedOccupancyVariances;
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.DayDaySurgeonNumberOccupiedBeds;
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.DayExpectedBedShortages;
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.DaySurgeonNumberBlockAssignments;
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.Gap;
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.NumberOfExploredNodes;
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.ObjectiveValue;
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.OverallWallTime;
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.SurgeonNumberAssignedDays;
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.TotalExpectedBedShortage;
    using Belien2007.A.E.O.InterfacesFactories.Results.MIP2.BedOccupancyMaximalWeightedSum;
    using Belien2007.A.E.O.InterfacesFactories.Results.Stochastic.StateNumberPatients;
    using Belien2007.A.E.O.InterfacesFactories.Results.Stochastic.SurgeonStateNumberPatients;

    public interface IResultsAbstractFactory
    {
        IBestBoundFactory CreateBestBoundFactory();

        IEBSFactory CreateEBSFactory();

        IGapFactory CreateGapFactory();

        INumberOfExploredNodesFactory CreateNumberOfExploredNodesFactory();

        IObjectiveValueFactory CreateObjectiveValueFactory();

        IOverallWallTimeFactory CreateOverallWallTimeFactory();

        IStateNumberPatientsFactory CreateStateNumberPatientsFactory();

        ISurgeonNumberAssignedDaysFactory CreateSurgeonNumberAssignedDaysFactory();

        ISurgeonStateNumberPatientsFactory CreateSurgeonStateNumberPatientsFactory();

        ITEBSFactory CreateTEBSFactory();

        IUFactory CreateUFactory();

        IVarianceFactory CreateVarianceFactory();

        IxFactory CreatexFactory();

        IγFactory CreateγFactory();

        IμFactory CreateμFactory();
    }
}