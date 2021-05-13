namespace Belien2007.A.E.O.InterfacesFactories.ResultElements.Common.SurgeonNumberAssignedDays
{
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ResultElements.Common.SurgeonNumberAssignedDays;

    public interface ISurgeonNumberAssignedDaysResultElementFactory
    {
        ISurgeonNumberAssignedDaysResultElement Create(
            IsIndexElement sIndexElement,
            int value);
    }
}