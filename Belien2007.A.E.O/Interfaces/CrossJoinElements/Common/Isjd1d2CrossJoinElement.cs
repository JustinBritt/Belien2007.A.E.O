namespace Belien2007.A.E.O.Interfaces.CrossJoinElements.Common
{
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;

    public interface Isjd1d2CrossJoinElement
    {
         IsIndexElement sIndexElement { get; }

         IjIndexElement jIndexElement { get; }

         Id1IndexElement d1IndexElement { get; }

         Id2IndexElement d2IndexElement { get; }
    }
}