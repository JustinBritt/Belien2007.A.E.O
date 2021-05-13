namespace Belien2007.A.E.O.InterfacesAbstractFactories
{
    using Belien2007.A.E.O.InterfacesFactories.Solutions.MIP2;
    using Belien2007.A.E.O.InterfacesFactories.Solutions.QMIP;
    using Belien2007.A.E.O.InterfacesFactories.Solutions.SMIP2;

    public interface ISolutionsAbstractFactory
    {
        IMIP2SolutionFactory CreateMIP2SolutionFactory();

        IQMIPSolutionFactory CreateQMIPSolutionFactory();

        ISMIP2SolutionFactory CreateSMIP2SolutionFactory();
    }
}