namespace Belien2007.A.E.O.InterfacesFactories.CrossJoinElements.Common
{
    using Belien2007.A.E.O.Interfaces.CrossJoinElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;

    public interface IsiCrossJoinElementFactory
    {
        IsiCrossJoinElement Create(
            IsIndexElement sIndexElement,
            IiIndexElement iIndexElement);
    }
}