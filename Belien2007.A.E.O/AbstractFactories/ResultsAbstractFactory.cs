namespace Belien2007.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Factories.Results.Common.BestBound;
    using Belien2007.A.E.O.Factories.Results.Common.DayBedOccupancyMeans;
    using Belien2007.A.E.O.Factories.Results.Common.DayBedOccupancyVariances;
    using Belien2007.A.E.O.Factories.Results.Common.DayDaySurgeonNumberOccupiedBeds;
    using Belien2007.A.E.O.Factories.Results.Common.DayExpectedBedShortages;
    using Belien2007.A.E.O.Factories.Results.Common.DaySurgeonNumberBlockAssignments;
    using Belien2007.A.E.O.Factories.Results.Common.Gap;
    using Belien2007.A.E.O.Factories.Results.Common.NumberOfExploredNodes;
    using Belien2007.A.E.O.Factories.Results.Common.ObjectiveValue;
    using Belien2007.A.E.O.Factories.Results.Common.OverallWallTime;
    using Belien2007.A.E.O.Factories.Results.Common.SurgeonNumberAssignedDays;
    using Belien2007.A.E.O.Factories.Results.Common.TotalExpectedBedShortage;
    using Belien2007.A.E.O.Factories.Results.MIP2.BedOccupancyMaximalWeightedSum;
    using Belien2007.A.E.O.Factories.Results.Stochastic.StateNumberPatients;
    using Belien2007.A.E.O.Factories.Results.Stochastic.SurgeonStateNumberPatients;
    using Belien2007.A.E.O.InterfacesAbstractFactories;
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.BestBound;
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.DayBedOccupancyMeans;
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.DayBedOccupancyVariances;
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.DayDaySurgeonNumberOccupiedBeds;
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.DayExpectedBedShortages;
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.DaySurgeonNumberBlockAssignments;
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.Gap;
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.NumberOfExploredNodes;
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.ObjectiveValue;
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.OverallWallTime;
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.SurgeonNumberAssignedDays;
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.TotalExpectedBedShortage;
    using Belien2007.A.E.O.InterfacesFactories.Results.MIP2.BedOccupancyMaximalWeightedSum;
    using Belien2007.A.E.O.InterfacesFactories.Results.Stochastic.StateNumberPatients;
    using Belien2007.A.E.O.InterfacesFactories.Results.Stochastic.SurgeonStateNumberPatients;

    internal sealed class ResultsAbstractFactory : IResultsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ResultsAbstractFactory()
        {
        }

        public IBestBoundFactory CreateBestBoundFactory()
        {
            IBestBoundFactory factory = null;

            try
            {
                factory = new BestBoundFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IEBSFactory CreateEBSFactory()
        {
            IEBSFactory factory = null;

            try
            {
                factory = new EBSFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IGapFactory CreateGapFactory()
        {
            IGapFactory factory = null;

            try
            {
                factory = new GapFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public INumberOfExploredNodesFactory CreateNumberOfExploredNodesFactory()
        {
            INumberOfExploredNodesFactory factory = null;

            try
            {
                factory = new NumberOfExploredNodesFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IObjectiveValueFactory CreateObjectiveValueFactory()
        {
            IObjectiveValueFactory factory = null;

            try
            {
                factory = new ObjectiveValueFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IOverallWallTimeFactory CreateOverallWallTimeFactory()
        {
            IOverallWallTimeFactory factory = null;

            try
            {
                factory = new OverallWallTimeFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IStateNumberPatientsFactory CreateStateNumberPatientsFactory()
        {
            IStateNumberPatientsFactory factory = null;

            try
            {
                factory = new StateNumberPatientsFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ISurgeonNumberAssignedDaysFactory CreateSurgeonNumberAssignedDaysFactory()
        {
            ISurgeonNumberAssignedDaysFactory factory = null;

            try
            {
                factory = new SurgeonNumberAssignedDaysFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ISurgeonStateNumberPatientsFactory CreateSurgeonStateNumberPatientsFactory()
        {
            ISurgeonStateNumberPatientsFactory factory = null;

            try
            {
                factory = new SurgeonStateNumberPatientsFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ITEBSFactory CreateTEBSFactory()
        {
            ITEBSFactory factory = null;

            try
            {
                factory = new TEBSFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IUFactory CreateUFactory()
        {
            IUFactory factory = null;

            try
            {
                factory = new UFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IVarianceFactory CreateVarianceFactory()
        {
            IVarianceFactory factory = null;

            try
            {
                factory = new VarianceFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IxFactory CreatexFactory()
        {
            IxFactory factory = null;

            try
            {
                factory = new xFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IγFactory CreateγFactory()
        {
            IγFactory factory = null;

            try
            {
                factory = new γFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IμFactory CreateμFactory()
        {
            IμFactory factory = null;

            try
            {
                factory = new μFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }
    }
}