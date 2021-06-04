namespace Belien2007.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Factories.ParameterElements.Common.ActivePeriods;
    using Belien2007.A.E.O.Factories.ParameterElements.Common.DayBedCapacities;
    using Belien2007.A.E.O.Factories.ParameterElements.Common.DayNumberAvailableTimeBlocks;
    using Belien2007.A.E.O.Factories.ParameterElements.Common.SurgeonDayLengthOfStayProbabilities;
    using Belien2007.A.E.O.Factories.ParameterElements.Common.SurgeonLengthOfStayMaximums;
    using Belien2007.A.E.O.Factories.ParameterElements.Common.SurgeonMaximumNumberPatients;
    using Belien2007.A.E.O.Factories.ParameterElements.Common.SurgeonNumberTimeBlocks;
    using Belien2007.A.E.O.Factories.ParameterElements.Stochastic.SurgeonNumberStates;
    using Belien2007.A.E.O.Factories.ParameterElements.Stochastic.SurgeonStateMaximumNumberPatients;
    using Belien2007.A.E.O.Factories.ParameterElements.Stochastic.SurgeonStateProbabilities;
    using Belien2007.A.E.O.InterfacesAbstractFactories;
    using Belien2007.A.E.O.InterfacesFactories.ParameterElements.Common.ActivePeriods;
    using Belien2007.A.E.O.InterfacesFactories.ParameterElements.Common.DayBedCapacities;
    using Belien2007.A.E.O.InterfacesFactories.ParameterElements.Common.DayNumberAvailableTimeBlocks;
    using Belien2007.A.E.O.InterfacesFactories.ParameterElements.Common.SurgeonDayLengthOfStayProbabilities;
    using Belien2007.A.E.O.InterfacesFactories.ParameterElements.Common.SurgeonLengthOfStayMaximums;
    using Belien2007.A.E.O.InterfacesFactories.ParameterElements.Common.SurgeonMaximumNumberPatients;
    using Belien2007.A.E.O.InterfacesFactories.ParameterElements.Common.SurgeonNumberTimeBlocks;
    using Belien2007.A.E.O.InterfacesFactories.ParameterElements.Stochastic.SurgeonNumberStates;
    using Belien2007.A.E.O.InterfacesFactories.ParameterElements.Stochastic.SurgeonStateMaximumNumberPatients;
    using Belien2007.A.E.O.InterfacesFactories.ParameterElements.Stochastic.SurgeonStateProbabilities;

    internal sealed class ParameterElementsAbstractFactory : IParameterElementsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ParameterElementsAbstractFactory()
        {
        }

        public IAParameterElementFactory CreateAParameterElementFactory()
        {
            IAParameterElementFactory factory = null;

            try
            {
                factory = new AParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IbParameterElementFactory CreatebParameterElementFactory()
        {
            IbParameterElementFactory factory = null;

            try
            {
                factory = new bParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IcParameterElementFactory CreatecParameterElementFactory()
        {
            IcParameterElementFactory factory = null;

            try
            {
                factory = new cParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ICommonnParameterElementFactory CreateCommonnParameterElementFactory()
        {
            ICommonnParameterElementFactory factory = null;

            try
            {
                factory = new CommonnParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IhParameterElementFactory CreatehParameterElementFactory()
        {
            IhParameterElementFactory factory = null;

            try
            {
                factory = new hParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ImParameterElementFactory CreatemParameterElementFactory()
        {
            ImParameterElementFactory factory = null;

            try
            {
                factory = new mParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IpParameterElementFactory CreatepParameterElementFactory()
        {
            IpParameterElementFactory factory = null;

            try
            {
                factory = new pParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IqParameterElementFactory CreateqParameterElementFactory()
        {
            IqParameterElementFactory factory = null;

            try
            {
                factory = new qParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IrParameterElementFactory CreaterParameterElementFactory()
        {
            IrParameterElementFactory factory = null;

            try
            {
                factory = new rParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IStochasticnParameterElementFactory CreateStochasticnParameterElementFactory()
        {
            IStochasticnParameterElementFactory factory = null;

            try
            {
                factory = new StochasticnParameterElementFactory();
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