namespace Belien2007.A.E.O.Interfaces.ResultElements.Common.DaySurgeonNumberBlockAssignments
{
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;

    public interface IxResultElement
    {
        IiIndexElement iIndexElement { get; }

        IsIndexElement sIndexElement { get; }

        int Value { get; }
    }
}