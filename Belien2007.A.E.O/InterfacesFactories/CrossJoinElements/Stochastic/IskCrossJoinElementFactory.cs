namespace Belien2007.A.E.O.InterfacesFactories.CrossJoinElements.Stochastic
{
    using Belien2007.A.E.O.Interfaces.CrossJoinElements.Stochastic;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;

    public interface IskCrossJoinElementFactory
    {
        IskCrossJoinElement Create(
            IsIndexElement sIndexElement,
            IkIndexElement kIndexElement);
    }
}