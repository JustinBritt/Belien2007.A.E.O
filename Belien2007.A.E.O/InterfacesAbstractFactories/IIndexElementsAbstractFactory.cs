namespace Belien2007.A.E.O.InterfacesAbstractFactories
{
    using Belien2007.A.E.O.InterfacesFactories.IndexElements.Common;
    using Belien2007.A.E.O.InterfacesFactories.IndexElements.Stochastic;

    public interface IIndexElementsAbstractFactory
    {
        IdIndexElementFactory CreatedIndexElementFactory();

        Id1IndexElementFactory Created1IndexElementFactory();

        Id2IndexElementFactory Created2IndexElementFactory();

        IiIndexElementFactory CreateiIndexElementFactory();

        IjIndexElementFactory CreatejIndexElementFactory();

        IkIndexElementFactory CreatekIndexElementFactory();

        IsIndexElementFactory CreatesIndexElementFactory();
    }
}