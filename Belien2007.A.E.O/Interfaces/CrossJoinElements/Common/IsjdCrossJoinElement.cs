namespace Belien2007.A.E.O.Interfaces.CrossJoinElements.Common
{
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;

    public interface IsjdCrossJoinElement
    {
        IsIndexElement sIndexElement { get; }

        IjIndexElement jIndexElement { get; }

        IdIndexElement dIndexElement { get; }
    }
}