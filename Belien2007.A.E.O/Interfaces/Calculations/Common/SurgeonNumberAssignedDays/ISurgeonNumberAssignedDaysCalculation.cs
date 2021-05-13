namespace Belien2007.A.E.O.Interfaces.Calculations.Common.SurgeonNumberAssignedDays
{
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.Interfaces.Results.Common.DaySurgeonNumberBlockAssignments;
    using Belien2007.A.E.O.Interfaces.Results.Common.SurgeonNumberAssignedDays;
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Common.SurgeonNumberAssignedDays;
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.SurgeonNumberAssignedDays;

    public interface ISurgeonNumberAssignedDaysCalculation
    {
        ISurgeonNumberAssignedDays Calculate(
            ISurgeonNumberAssignedDaysResultElementFactory surgeonNumberAssignedDaysResultElementFactory,
            ISurgeonNumberAssignedDaysFactory surgeonNumberAssignedDaysFactory,
            ISurgeonNumberAssignedDaysResultElementCalculation surgeonNumberAssignedDaysResultElementCalculation,
            Is s,
            Ix x);
    }
}