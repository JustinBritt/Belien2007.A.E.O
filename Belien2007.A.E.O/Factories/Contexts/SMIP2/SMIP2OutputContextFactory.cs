namespace Belien2007.A.E.O.Factories.Contexts.SMIP2
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Belien2007.A.E.O.Classes.Contexts.SMIP2;
    using Belien2007.A.E.O.InterfacesAbstractFactories;
    using Belien2007.A.E.O.Interfaces.Contexts.SMIP2;
    using Belien2007.A.E.O.Interfaces.Models.SMIP2;
    using Belien2007.A.E.O.InterfacesFactories.Contexts.SMIP2;

    internal sealed class SMIP2OutputContextFactory : ISMIP2OutputContextFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SMIP2OutputContextFactory()
        {
        }

        public ISMIP2OutputContext Create(
            ICalculationsAbstractFactory calculationsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IResultElementsAbstractFactory resultElementsAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            ISMIP2Model SMIP2Model,
            Solution solution)
        {
            ISMIP2OutputContext context = null;

            try
            {
                context = new SMIP2OutputContext(
                    calculationsAbstractFactory,
                    dependenciesAbstractFactory,
                    resultElementsAbstractFactory,
                    resultsAbstractFactory,
                    SMIP2Model,
                    solution);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return context;
        }
    }
}