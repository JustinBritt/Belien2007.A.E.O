namespace Belien2007.A.E.O.InterfacesAbstractFactories
{
    using Belien2007.A.E.O.InterfacesFactories.CrossJoins.Common;
    using Belien2007.A.E.O.InterfacesFactories.CrossJoins.Stochastic;

    public interface ICrossJoinsAbstractFactory
    {
        Id1d2Factory Created1d2Factory();

        IsiFactory CreatesiFactory();

        IsjFactory CreatesjFactory();

        IsjdFactory CreatesjdFactory();

        Isjd1Factory Createsjd1Factory();

        Isjd1d2Factory Createsjd1d2Factory();

        IskFactory CreateskFactory();
    }
}