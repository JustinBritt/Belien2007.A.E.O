namespace Belien2007.A.E.O.Classes.Calculations.Common.SurgeonNumberAssignedDays
{
    using System.Collections.Immutable;
    using System.Linq;

    using Belien2007.A.E.O.Interfaces.Calculations.Common.SurgeonNumberAssignedDays;
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.Interfaces.Results.Common.DaySurgeonNumberBlockAssignments;
    using Belien2007.A.E.O.Interfaces.Results.Common.SurgeonNumberAssignedDays;
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Common.SurgeonNumberAssignedDays;
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.SurgeonNumberAssignedDays;

    internal sealed class SurgeonNumberAssignedDaysCalculation : ISurgeonNumberAssignedDaysCalculation
    {
        public SurgeonNumberAssignedDaysCalculation()
        {
        }

        public ISurgeonNumberAssignedDays Calculate(
            ISurgeonNumberAssignedDaysResultElementFactory surgeonNumberAssignedDaysResultElementFactory,
            ISurgeonNumberAssignedDaysFactory surgeonNumberAssignedDaysFactory,
            ISurgeonNumberAssignedDaysResultElementCalculation surgeonNumberAssignedDaysResultElementCalculation,
            Is s,
            Ix x)
        {
            return surgeonNumberAssignedDaysFactory.Create(
                s.Value.Values
                .Select(w => surgeonNumberAssignedDaysResultElementCalculation.Calculate(
                    surgeonNumberAssignedDaysResultElementFactory,
                    w,
                    x))
                .ToImmutableList());
        }
    }
}