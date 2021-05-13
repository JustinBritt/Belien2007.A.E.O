namespace Belien2007.A.E.O.Interfaces.CrossJoinElements.Common
{
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;

    public interface IsiCrossJoinElement
    {
        IsIndexElement sIndexElement { get; }

        IiIndexElement iIndexElement { get; }
    }
}