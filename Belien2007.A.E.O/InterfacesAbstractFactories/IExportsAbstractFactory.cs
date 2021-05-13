namespace Belien2007.A.E.O.InterfacesAbstractFactories
{
    using Belien2007.A.E.O.InterfacesFactories.Exports.MIP2;
    using Belien2007.A.E.O.InterfacesFactories.Exports.QMIP;
    using Belien2007.A.E.O.InterfacesFactories.Exports.SMIP2;

    public interface IExportsAbstractFactory
    {
        IMIP2ExportFactory CreateMIP2ExportFactory();

        IQMIPExportFactory CreateQMIPExportFactory();

        ISMIP2ExportFactory CreateSMIP2ExportFactory();
    }
}