namespace Belien2007.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Factories.Calculations.Common.DayExpectedBedShortages;
    using Belien2007.A.E.O.Factories.Calculations.Common.SurgeonNumberAssignedDays;
    using Belien2007.A.E.O.Factories.Calculations.Common.TotalExpectedBedShortage;
    using Belien2007.A.E.O.Factories.Calculations.Stochastic.StateNumberPatients;
    using Belien2007.A.E.O.Factories.Calculations.Stochastic.SurgeonStateNumberPatients;
    using Belien2007.A.E.O.InterfacesAbstractFactories;
    using Belien2007.A.E.O.InterfacesFactories.Calculations.Common.DayExpectedBedShortages;
    using Belien2007.A.E.O.InterfacesFactories.Calculations.Common.SurgeonNumberAssignedDays;
    using Belien2007.A.E.O.InterfacesFactories.Calculations.Common.TotalExpectedBedShortage;
    using Belien2007.A.E.O.InterfacesFactories.Calculations.Stochastic.StateNumberPatients;
    using Belien2007.A.E.O.InterfacesFactories.Calculations.Stochastic.SurgeonStateNumberPatients;

    internal sealed class CalculationsAbstractFactory : ICalculationsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CalculationsAbstractFactory()
        {
        }

        public IEBSCalculationFactory CreateEBSCalculationFactory()
        {
            IEBSCalculationFactory factory = null;

            try
            {
                factory = new EBSCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IEBSResultElementCalculationFactory CreateEBSResultElementCalculationFactory()
        {
            IEBSResultElementCalculationFactory factory = null;

            try
            {
                factory = new EBSResultElementCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IStateNumberPatientsCalculationFactory CreateStateNumberPatientsCalculationFactory()
        {
            IStateNumberPatientsCalculationFactory factory = null;

            try
            {
                factory = new StateNumberPatientsCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IStateNumberPatientsResultElementCalculationFactory CreateStateNumberPatientsResultElementCalculationFactory()
        {
            IStateNumberPatientsResultElementCalculationFactory factory = null;

            try
            {
                factory = new StateNumberPatientsResultElementCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ISurgeonNumberAssignedDaysCalculationFactory CreateSurgeonNumberAssignedDaysCalculationFactory()
        {
            ISurgeonNumberAssignedDaysCalculationFactory factory = null;

            try
            {
                factory = new SurgeonNumberAssignedDaysCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ISurgeonNumberAssignedDaysResultElementCalculationFactory CreateSurgeonNumberAssignedDaysResultElementCalculationFactory()
        {
            ISurgeonNumberAssignedDaysResultElementCalculationFactory factory = null;

            try
            {
                factory = new SurgeonNumberAssignedDaysResultElementCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ISurgeonStateNumberPatientsCalculationFactory CreateSurgeonStateNumberPatientsCalculationFactory()
        {
            ISurgeonStateNumberPatientsCalculationFactory factory = null;

            try
            {
                factory = new SurgeonStateNumberPatientsCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ISurgeonStateNumberPatientsResultElementCalculationFactory CreateSurgeonStateNumberPatientsResultElementCalculationFactory()
        {
            ISurgeonStateNumberPatientsResultElementCalculationFactory factory = null;

            try
            {
                factory = new SurgeonStateNumberPatientsResultElementCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ITEBSCalculationFactory CreateTEBSCalculationFactory()
        {
            ITEBSCalculationFactory factory = null;

            try
            {
                factory = new TEBSCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }
    }
}