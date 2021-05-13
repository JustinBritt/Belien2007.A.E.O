namespace Belien2007.A.E.O.InterfacesAbstractFactories
{
    using Belien2007.A.E.O.InterfacesFactories.Variables.Common;
    using Belien2007.A.E.O.InterfacesFactories.Variables.MIP2;

    public interface IVariablesAbstractFactory
    {
        IVarianceFactory CreateVarianceFactory();

        IxFactory CreatexFactory();

        IγFactory CreateγFactory();

        IμFactory CreateμFactory();
    }
}