namespace Belien2007.A.E.O.InterfacesFactories.Contexts.QMIP
{
    using OPTANO.Modeling.Optimization;

    using Belien2007.A.E.O.InterfacesAbstractFactories;
    using Belien2007.A.E.O.Interfaces.Contexts.QMIP;
    using Belien2007.A.E.O.Interfaces.Models.QMIP;

    public interface IQMIPOutputContextFactory
    {
        IQMIPOutputContext Create(
            ICalculationsAbstractFactory calculationsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IResultElementsAbstractFactory resultElementsAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            IQMIPModel QMIPModel,
            Solution solution);
    }
}