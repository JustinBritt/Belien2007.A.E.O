namespace Belien2007.A.E.O.InterfacesAbstractFactories
{
    using Belien2007.A.E.O.InterfacesFactories.ObjectiveFunctions.MIP2;
    using Belien2007.A.E.O.InterfacesFactories.ObjectiveFunctions.QMIP;

    public interface IObjectiveFunctionsAbstractFactory
    {
        IMIP2ObjectiveFunctionFactory CreateMIP2ObjectiveFunctionFactory();

        IQMIPObjectiveFunctionFactory CreateQMIPObjectiveFunctionFactory();
    }
}