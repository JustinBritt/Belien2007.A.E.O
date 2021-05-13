namespace Belien2007.A.E.O.InterfacesAbstractFactories
{
    using Belien2007.A.E.O.InterfacesFactories.CrossJoinElements.Common;
    using Belien2007.A.E.O.InterfacesFactories.CrossJoinElements.Stochastic;

    public interface ICrossJoinElementsAbstractFactory
    {
        Id1d2CrossJoinElementFactory Created1d2CrossJoinElementFactory();

        IsiCrossJoinElementFactory CreatesiCrossJoinElementFactory();

        IsjCrossJoinElementFactory CreatesjCrossJoinElementFactory();

        IsjdCrossJoinElementFactory CreatesjdCrossJoinElementFactory();

        Isjd1CrossJoinElementFactory Createsjd1CrossJoinElementFactory();

        Isjd1d2CrossJoinElementFactory Createsjd1d2CrossJoinElementFactory();

        IskCrossJoinElementFactory CreateskCrossJoinElementFactory();
    }
}