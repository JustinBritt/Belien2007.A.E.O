namespace Belien2007.A.E.O.InterfacesAbstractFactories
{
    using Belien2007.A.E.O.InterfacesFactories.Indices.Common;
    using Belien2007.A.E.O.InterfacesFactories.Indices.Stochastic;

    public interface IIndicesAbstractFactory
    {
        IdFactory CreatedFactory();

        Id1Factory Created1Factory();

        Id2Factory Created2Factory();

        IiFactory CreateiFactory();

        IjFactory CreatejFactory();

        IkFactory CreatekFactory();

        IsFactory CreatesFactory();
    }
}