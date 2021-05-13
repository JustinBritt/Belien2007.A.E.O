namespace Belien2007.A.E.O.Classes.Calculations.Common.SurgeonNumberAssignedDays
{
    using System;
    using System.Linq;

    using Belien2007.A.E.O.Interfaces.Calculations.Common.SurgeonNumberAssignedDays;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ResultElements.Common.SurgeonNumberAssignedDays;
    using Belien2007.A.E.O.Interfaces.Results.Common.DaySurgeonNumberBlockAssignments;
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Common.SurgeonNumberAssignedDays;

    internal sealed class SurgeonNumberAssignedDaysResultElementCalculation : ISurgeonNumberAssignedDaysResultElementCalculation
    {
        public SurgeonNumberAssignedDaysResultElementCalculation()
        {
        }

        public ISurgeonNumberAssignedDaysResultElement Calculate(
            ISurgeonNumberAssignedDaysResultElementFactory surgeonNumberAssignedDaysResultElementFactory,
            IsIndexElement sIndexElement,
            Ix x)
        {
            return surgeonNumberAssignedDaysResultElementFactory.Create(
                sIndexElement,
                x.Value.Where(i => i.sIndexElement == sIndexElement && i.Value > 0).Select(i => i.iIndexElement.Value.ToDateTimeOffset(TimeSpan.Zero).UtcDateTime.DayOfWeek).Distinct().Count());
        }
    }
}