namespace Belien2007.A.E.O.InterfacesFactories.CrossJoinElements.Common
{
    using Belien2007.A.E.O.Interfaces.CrossJoinElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;

    public interface Isjd1d2CrossJoinElementFactory
    {
        Isjd1d2CrossJoinElement Create(
            IsIndexElement sIndexElement,
            IjIndexElement jIndexElement,
            Id1IndexElement d1IndexElement,
            Id2IndexElement d2IndexElement);
    }
}