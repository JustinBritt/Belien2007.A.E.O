namespace Belien2007.A.E.O.InterfacesAbstractFactories
{
    using Belien2007.A.E.O.InterfacesFactories.Models.MIP2;
    using Belien2007.A.E.O.InterfacesFactories.Models.QMIP;
    using Belien2007.A.E.O.InterfacesFactories.Models.SMIP2;

    public interface IModelsAbstractFactory
    {
        IMIP2ModelFactory CreateMIP2ModelFactory();

        IQMIPModelFactory CreateQMIPModelFactory();

        ISMIP2ModelFactory CreateSMIP2ModelFactory();
    }
}