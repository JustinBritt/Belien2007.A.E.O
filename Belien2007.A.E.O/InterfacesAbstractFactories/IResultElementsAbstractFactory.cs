namespace Belien2007.A.E.O.InterfacesAbstractFactories
{
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Common.DayBedOccupancyMeans;
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Common.DayBedOccupancyVariances;
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Common.DayDaySurgeonNumberOccupiedBeds;
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Common.DayExpectedBedShortages;
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Common.DaySurgeonNumberBlockAssignments;
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Common.SurgeonNumberAssignedDays;
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Stochastic.StateNumberPatients;
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Stochastic.SurgeonStateNumberPatients;

    public interface IResultElementsAbstractFactory
    {
        IEBSResultElementFactory CreateEBSResultElementFactory();

        IStateNumberPatientsResultElementFactory CreateStateNumberPatientsResultElementFactory();

        ISurgeonNumberAssignedDaysResultElementFactory CreateSurgeonNumberAssignedDaysResultElementFactory();

        ISurgeonStateNumberPatientsResultElementFactory CreateSurgeonStateNumberPatientsResultElementFactory();

        IUResultElementFactory CreateUResultElementFactory();

        IVarianceResultElementFactory CreateVarianceResultElementFactory();

        IxResultElementFactory CreatexResultElementFactory();

        IμResultElementFactory CreateμResultElementFactory();
    }
}