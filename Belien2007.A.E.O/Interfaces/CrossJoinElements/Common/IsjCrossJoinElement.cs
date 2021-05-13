namespace Belien2007.A.E.O.Interfaces.CrossJoinElements.Common
{
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;

    public interface IsjCrossJoinElement
    {
        IsIndexElement sIndexElement { get; }

        IjIndexElement jIndexElement { get; }
    }
}