namespace Belien2007.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Factories.ResultElements.Common.DayBedOccupancyMeans;
    using Belien2007.A.E.O.Factories.ResultElements.Common.DayBedOccupancyVariances;
    using Belien2007.A.E.O.Factories.ResultElements.Common.DayDaySurgeonNumberOccupiedBeds;
    using Belien2007.A.E.O.Factories.ResultElements.Common.DayExpectedBedShortages;
    using Belien2007.A.E.O.Factories.ResultElements.Common.DaySurgeonNumberBlockAssignments;
    using Belien2007.A.E.O.Factories.ResultElements.Common.SurgeonNumberAssignedDays;
    using Belien2007.A.E.O.Factories.ResultElements.Stochastic.StateNumberPatients;
    using Belien2007.A.E.O.Factories.ResultElements.Stochastic.SurgeonStateNumberPatients;
    using Belien2007.A.E.O.InterfacesAbstractFactories;
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Common.DayBedOccupancyMeans;
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Common.DayBedOccupancyVariances;
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Common.DayDaySurgeonNumberOccupiedBeds;
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Common.DayExpectedBedShortages;
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Common.DaySurgeonNumberBlockAssignments;
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Common.SurgeonNumberAssignedDays;
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Stochastic.StateNumberPatients;
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Stochastic.SurgeonStateNumberPatients;

    internal sealed class ResultElementsAbstractFactory : IResultElementsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ResultElementsAbstractFactory()
        {
        }

        public IEBSResultElementFactory CreateEBSResultElementFactory()
        {
            IEBSResultElementFactory factory = null;

            try
            {
                factory = new EBSResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IStateNumberPatientsResultElementFactory CreateStateNumberPatientsResultElementFactory()
        {
            IStateNumberPatientsResultElementFactory factory = null;

            try
            {
                factory = new StateNumberPatientsResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgeonNumberAssignedDaysResultElementFactory CreateSurgeonNumberAssignedDaysResultElementFactory()
        {
            ISurgeonNumberAssignedDaysResultElementFactory factory = null;

            try
            {
                factory = new SurgeonNumberAssignedDaysResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgeonStateNumberPatientsResultElementFactory CreateSurgeonStateNumberPatientsResultElementFactory()
        {
            ISurgeonStateNumberPatientsResultElementFactory factory = null;

            try
            {
                factory = new SurgeonStateNumberPatientsResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IUResultElementFactory CreateUResultElementFactory()
        {
            IUResultElementFactory factory = null;

            try
            {
                factory = new UResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IVarianceResultElementFactory CreateVarianceResultElementFactory()
        {
            IVarianceResultElementFactory factory = null;

            try
            {
                factory = new VarianceResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IxResultElementFactory CreatexResultElementFactory()
        {
            IxResultElementFactory factory = null;

            try
            {
                factory = new xResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IμResultElementFactory CreateμResultElementFactory()
        {
            IμResultElementFactory factory = null;

            try
            {
                factory = new μResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }
    }
}