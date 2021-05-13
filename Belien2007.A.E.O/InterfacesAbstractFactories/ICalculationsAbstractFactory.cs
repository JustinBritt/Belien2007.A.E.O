namespace Belien2007.A.E.O.InterfacesAbstractFactories
{
    using Belien2007.A.E.O.InterfacesFactories.Calculations.Common.DayExpectedBedShortages;
    using Belien2007.A.E.O.InterfacesFactories.Calculations.Common.SurgeonNumberAssignedDays;
    using Belien2007.A.E.O.InterfacesFactories.Calculations.Common.TotalExpectedBedShortage;
    using Belien2007.A.E.O.InterfacesFactories.Calculations.Stochastic.StateNumberPatients;
    using Belien2007.A.E.O.InterfacesFactories.Calculations.Stochastic.SurgeonStateNumberPatients;

    public interface ICalculationsAbstractFactory
    {
        IEBSCalculationFactory CreateEBSCalculationFactory();

        IEBSResultElementCalculationFactory CreateEBSResultElementCalculationFactory();

        IStateNumberPatientsCalculationFactory CreateStateNumberPatientsCalculationFactory();

        IStateNumberPatientsResultElementCalculationFactory CreateStateNumberPatientsResultElementCalculationFactory();

        ISurgeonNumberAssignedDaysCalculationFactory CreateSurgeonNumberAssignedDaysCalculationFactory();

        ISurgeonNumberAssignedDaysResultElementCalculationFactory CreateSurgeonNumberAssignedDaysResultElementCalculationFactory();

        ISurgeonStateNumberPatientsCalculationFactory CreateSurgeonStateNumberPatientsCalculationFactory();

        ISurgeonStateNumberPatientsResultElementCalculationFactory CreateSurgeonStateNumberPatientsResultElementCalculationFactory();

        ITEBSCalculationFactory CreateTEBSCalculationFactory();
    }
}