namespace Belien2007.A.E.O.InterfacesFactories.Configurations.MIP2
{
    using OPTANO.Modeling.Optimization.Configuration;

    using Belien2007.A.E.O.Interfaces.Configurations.MIP2;

    public interface IMIP2ConfigurationFactory
    {
        IMIP2Configuration Create(
            Configuration configuration);
    }
}