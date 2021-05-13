namespace Belien2007.A.E.O.InterfacesFactories.Contexts.MIP2
{
    using OPTANO.Modeling.Optimization;

    using Belien2007.A.E.O.InterfacesAbstractFactories;
    using Belien2007.A.E.O.Interfaces.Contexts.MIP2;
    using Belien2007.A.E.O.Interfaces.Models.MIP2;

    public interface IMIP2OutputContextFactory
    {
        IMIP2OutputContext Create(
            ICalculationsAbstractFactory calculationsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IResultElementsAbstractFactory resultElementsAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            IMIP2Model MIP2Model,
            Solution solution);
    }
}