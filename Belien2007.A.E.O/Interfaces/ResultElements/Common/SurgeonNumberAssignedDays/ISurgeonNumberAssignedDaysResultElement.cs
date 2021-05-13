namespace Belien2007.A.E.O.Interfaces.ResultElements.Common.SurgeonNumberAssignedDays
{
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;

    public interface ISurgeonNumberAssignedDaysResultElement
    {
        IsIndexElement sIndexElement { get; }

        int Value { get; }
    }
}