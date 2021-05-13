namespace Belien2007.A.E.O.Interfaces.CrossJoinElements.Stochastic
{
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;

    public interface IskCrossJoinElement
    {
        IsIndexElement sIndexElement { get; }

        IkIndexElement kIndexElement { get; }
    }
}