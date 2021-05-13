namespace Belien2007.A.E.O.InterfacesFactories.CrossJoinElements.Common
{
    using Belien2007.A.E.O.Interfaces.CrossJoinElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;

    public interface IsjCrossJoinElementFactory
    {
        IsjCrossJoinElement Create(
            IsIndexElement sIndexElement,
            IjIndexElement jIndexElement);
    }
}