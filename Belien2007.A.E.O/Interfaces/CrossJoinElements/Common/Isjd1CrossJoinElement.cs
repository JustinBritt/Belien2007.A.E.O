namespace Belien2007.A.E.O.Interfaces.CrossJoinElements.Common
{
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;

    public interface Isjd1CrossJoinElement
    {
        IsIndexElement sIndexElement { get; }

        IjIndexElement jIndexElement { get; }

        Id1IndexElement d1IndexElement { get; }
    }
}