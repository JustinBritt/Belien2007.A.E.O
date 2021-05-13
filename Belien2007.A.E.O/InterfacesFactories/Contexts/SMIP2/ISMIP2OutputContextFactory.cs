namespace Belien2007.A.E.O.InterfacesFactories.Contexts.SMIP2
{
    using OPTANO.Modeling.Optimization;

    using Belien2007.A.E.O.InterfacesAbstractFactories;
    using Belien2007.A.E.O.Interfaces.Contexts.SMIP2;
    using Belien2007.A.E.O.Interfaces.Models.SMIP2;

    public interface ISMIP2OutputContextFactory
    {
        ISMIP2OutputContext Create(
            ICalculationsAbstractFactory calculationsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IResultElementsAbstractFactory resultElementsAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            ISMIP2Model SMIP2Model,
            Solution solution);
    }
}