namespace Belien2007.A.E.O.InterfacesFactories.ResultElements.Common.DaySurgeonNumberBlockAssignments
{
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ResultElements.Common.DaySurgeonNumberBlockAssignments;

    public interface IxResultElementFactory
    {
        IxResultElement Create(
            IiIndexElement iIndexElement,
            IsIndexElement sIndexElement,
            int value);
    }
}