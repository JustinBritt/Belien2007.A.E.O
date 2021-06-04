namespace Belien2007.A.E.O.Factories.Contexts.QMIP
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Belien2007.A.E.O.Classes.Contexts.QMIP;
    using Belien2007.A.E.O.InterfacesAbstractFactories;
    using Belien2007.A.E.O.Interfaces.Contexts.QMIP;
    using Belien2007.A.E.O.Interfaces.Models.QMIP;
    using Belien2007.A.E.O.InterfacesFactories.Contexts.QMIP;

    internal sealed class QMIPOutputContextFactory : IQMIPOutputContextFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public QMIPOutputContextFactory()
        {
        }

        public IQMIPOutputContext Create(
            ICalculationsAbstractFactory calculationsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IResultElementsAbstractFactory resultElementsAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            IQMIPModel QMIPModel,
            Solution solution)
        {
            IQMIPOutputContext context = null;

            try
            {
                context = new QMIPOutputContext(
                    calculationsAbstractFactory,
                    dependenciesAbstractFactory,
                    resultElementsAbstractFactory,
                    resultsAbstractFactory,
                    QMIPModel,
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