namespace Belien2007.A.E.O.InterfacesAbstractFactories
{
    using Belien2007.A.E.O.InterfacesFactories.Contexts.MIP2;
    using Belien2007.A.E.O.InterfacesFactories.Contexts.QMIP;
    using Belien2007.A.E.O.InterfacesFactories.Contexts.SMIP2;

    public interface IContextsAbstractFactory
    {
        IMIP2InputContextFactory CreateMIP2InputContextFactory();

        IMIP2OutputContextFactory CreateMIP2OutputContextFactory();

        IQMIPInputContextFactory CreateQMIPInputContextFactory();

        IQMIPOutputContextFactory CreateQMIPOutputContextFactory();

        ISMIP2InputContextFactory CreateSMIP2InputContextFactory();

        ISMIP2OutputContextFactory CreateSMIP2OutputContextFactory();
    }
}