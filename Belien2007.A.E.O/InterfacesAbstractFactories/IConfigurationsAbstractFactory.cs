namespace Belien2007.A.E.O.InterfacesAbstractFactories
{
    using Belien2007.A.E.O.InterfacesFactories.Configurations.MIP2;
    using Belien2007.A.E.O.InterfacesFactories.Configurations.QMIP;
    using Belien2007.A.E.O.InterfacesFactories.Configurations.SMIP2;

    public interface IConfigurationsAbstractFactory
    {
        IMIP2ConfigurationFactory CreateMIP2ConfigurationFactory();

        IQMIPConfigurationFactory CreateQMIPConfigurationFactory();

        ISMIP2ConfigurationFactory CreateSMIP2ConfigurationFactory();
    }
}