namespace Belien2007.A.E.O.Factories.Contexts.MIP2
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Belien2007.A.E.O.Classes.Contexts.MIP2;
    using Belien2007.A.E.O.InterfacesAbstractFactories;
    using Belien2007.A.E.O.Interfaces.Contexts.MIP2;
    using Belien2007.A.E.O.Interfaces.Models.MIP2;
    using Belien2007.A.E.O.InterfacesFactories.Contexts.MIP2;
    
    internal sealed class MIP2OutputContextFactory : IMIP2OutputContextFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public MIP2OutputContextFactory()
        {
        }

        public IMIP2OutputContext Create(
            ICalculationsAbstractFactory calculationsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IResultElementsAbstractFactory resultElementsAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            IMIP2Model MIP2Model,
            Solution solution)
        {
            IMIP2OutputContext context = null;

            try
            {
                context = new MIP2OutputContext(
                    calculationsAbstractFactory,
                    dependenciesAbstractFactory,
                    resultElementsAbstractFactory,
                    resultsAbstractFactory,
                    MIP2Model,
                    solution);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return context;
        }
    }
}