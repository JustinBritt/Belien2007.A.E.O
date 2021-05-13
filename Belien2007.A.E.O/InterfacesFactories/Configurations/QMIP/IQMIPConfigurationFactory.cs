namespace Belien2007.A.E.O.InterfacesFactories.Configurations.QMIP
{
    using OPTANO.Modeling.Optimization.Configuration;

    using Belien2007.A.E.O.Interfaces.Configurations.QMIP;

    public interface IQMIPConfigurationFactory
    {
        IQMIPConfiguration Create(
            Configuration configuration);
    }
}