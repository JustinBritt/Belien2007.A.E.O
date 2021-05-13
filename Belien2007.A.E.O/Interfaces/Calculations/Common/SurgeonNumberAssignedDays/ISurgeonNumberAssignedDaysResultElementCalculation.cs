namespace Belien2007.A.E.O.Interfaces.Calculations.Common.SurgeonNumberAssignedDays
{
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ResultElements.Common.SurgeonNumberAssignedDays;
    using Belien2007.A.E.O.Interfaces.Results.Common.DaySurgeonNumberBlockAssignments;
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Common.SurgeonNumberAssignedDays;

    public interface ISurgeonNumberAssignedDaysResultElementCalculation
    {
        ISurgeonNumberAssignedDaysResultElement Calculate(
            ISurgeonNumberAssignedDaysResultElementFactory surgeonNumberAssignedDaysResultElementFactory,
            IsIndexElement sIndexElement,
            Ix x);
    }
}