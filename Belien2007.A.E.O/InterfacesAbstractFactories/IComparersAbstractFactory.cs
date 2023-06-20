namespace Belien2007.A.E.O.InterfacesAbstractFactories
{
    using Belien2007.A.E.O.InterfacesFactories.Comparers;

    public interface IComparersAbstractFactory
    {
        IOrganizationComparerFactory CreateOrganizationComparerFactory();
    }
}