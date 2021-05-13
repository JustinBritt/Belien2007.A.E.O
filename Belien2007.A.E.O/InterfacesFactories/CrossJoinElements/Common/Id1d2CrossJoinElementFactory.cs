namespace Belien2007.A.E.O.InterfacesFactories.CrossJoinElements.Common
{
    using Belien2007.A.E.O.Interfaces.CrossJoinElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;

    public interface Id1d2CrossJoinElementFactory
    {
        Id1d2CrossJoinElement Create(
            Id1IndexElement d1IndexElement,
            Id2IndexElement d2IndexElement);
    }
}