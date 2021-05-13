namespace Belien2007.A.E.O.InterfacesFactories.Configurations.SMIP2
{
    using OPTANO.Modeling.Optimization.Configuration;

    using Belien2007.A.E.O.Interfaces.Configurations.SMIP2;

    public interface ISMIP2ConfigurationFactory
    {
        ISMIP2Configuration Create(
            Configuration configuration);
    }
}