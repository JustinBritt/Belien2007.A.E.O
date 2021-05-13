namespace Belien2007.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Factories.Parameters.Common.ActivePeriods;
    using Belien2007.A.E.O.Factories.Parameters.Common.DayBedCapacities;
    using Belien2007.A.E.O.Factories.Parameters.Common.DayNumberAvailableTimeBlocks;
    using Belien2007.A.E.O.Factories.Parameters.Common.SurgeonDayLengthOfStayProbabilities;
    using Belien2007.A.E.O.Factories.Parameters.Common.SurgeonLengthOfStayMaximums;
    using Belien2007.A.E.O.Factories.Parameters.Common.SurgeonMaximumNumberPatients;
    using Belien2007.A.E.O.Factories.Parameters.Common.SurgeonNumberTimeBlocks;
    using Belien2007.A.E.O.Factories.Parameters.MIP2.Weights;
    using Belien2007.A.E.O.Factories.Parameters.Stochastic.SurgeonNumberStates;
    using Belien2007.A.E.O.Factories.Parameters.Stochastic.SurgeonStateMaximumNumberPatients;
    using Belien2007.A.E.O.Factories.Parameters.Stochastic.SurgeonStateProbabilities;
    using Belien2007.A.E.O.InterfacesAbstractFactories;
    using Belien2007.A.E.O.InterfacesFactories.Parameters.Common.ActivePeriods;
    using Belien2007.A.E.O.InterfacesFactories.Parameters.Common.DayBedCapacities;
    using Belien2007.A.E.O.InterfacesFactories.Parameters.Common.DayNumberAvailableTimeBlocks;
    using Belien2007.A.E.O.InterfacesFactories.Parameters.Common.SurgeonDayLengthOfStayProbabilities;
    using Belien2007.A.E.O.InterfacesFactories.Parameters.Common.SurgeonLengthOfStayMaximums;
    using Belien2007.A.E.O.InterfacesFactories.Parameters.Common.SurgeonMaximumNumberPatients;
    using Belien2007.A.E.O.InterfacesFactories.Parameters.Common.SurgeonNumberTimeBlocks;
    using Belien2007.A.E.O.InterfacesFactories.Parameters.MIP2.Weights;
    using Belien2007.A.E.O.InterfacesFactories.Parameters.Stochastic.SurgeonNumberStates;
    using Belien2007.A.E.O.InterfacesFactories.Parameters.Stochastic.SurgeonStateMaximumNumberPatients;
    using Belien2007.A.E.O.InterfacesFactories.Parameters.Stochastic.SurgeonStateProbabilities;

    internal sealed class ParametersAbstractFactory : IParametersAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ParametersAbstractFactory()
        {
        }

        public IAFactory CreateAFactory()
        {
            IAFactory factory = null;

            try
            {
                factory = new AFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IbFactory CreatebFactory()
        {
            IbFactory factory = null;

            try
            {
                factory = new bFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IcFactory CreatecFactory()
        {
            IcFactory factory = null;

            try
            {
                factory = new cFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ICommonnFactory CreateCommonnFactory()
        {
            ICommonnFactory factory = null;

            try
            {
                factory = new CommonnFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IhFactory CreatehFactory()
        {
            IhFactory factory = null;

            try
            {
                factory = new hFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ImFactory CreatemFactory()
        {
            ImFactory factory = null;

            try
            {
                factory = new mFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IpFactory CreatepFactory()
        {
            IpFactory factory = null;

            try
            {
                factory = new pFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IqFactory CreateqFactory()
        {
            IqFactory factory = null;

            try
            {
                factory = new qFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IrFactory CreaterFactory()
        {
            IrFactory factory = null;

            try
            {
                factory = new rFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IStochasticnFactory CreateStochasticnFactory()
        {
            IStochasticnFactory factory = null;

            try
            {
                factory = new StochasticnFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IwMeanFactory CreatewMeanFactory()
        {
            IwMeanFactory factory = null;

            try
            {
                factory = new wMeanFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IwVarianceFactory CreatewVarianceFactory()
        {
            IwVarianceFactory factory = null;

            try
            {
                factory = new wVarianceFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }
    }
}