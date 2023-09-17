namespace Belien2007.A.E.O.Classes.Contexts.QMIP
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using OPTANO.Modeling.Optimization;

    using Belien2007.A.E.O.InterfacesAbstractFactories;
    using Belien2007.A.E.O.Interfaces.Contexts.QMIP;
    using Belien2007.A.E.O.Interfaces.Models.QMIP;

    internal sealed class QMIPOutputContext : IQMIPOutputContext
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public QMIPOutputContext(
            ICalculationsAbstractFactory calculationsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IResultElementsAbstractFactory resultElementsAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            IQMIPModel QMIPModel,
            Solution solution)
        {
            // BestBound
            this.BestBound = resultsAbstractFactory.CreateBestBoundFactory().Create(
                (decimal)solution.BestBound)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // Gap
            this.Gap = resultsAbstractFactory.CreateGapFactory().Create(
                (decimal)solution.Gap)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // NumberOfExploredNodes
            this.NumberOfExploredNodes = resultsAbstractFactory.CreateNumberOfExploredNodesFactory().Create(
                solution.NumberOfExploredNodes)
                .GetValueForOutputContext();

            // ObjectiveValue
            this.ObjectiveValue = resultsAbstractFactory.CreateObjectiveValueFactory().Create(
                (decimal)solution.ObjectiveValues.SingleOrDefault().Value)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // OverallWallTime
            this.OverallWallTime = resultsAbstractFactory.CreateOverallWallTimeFactory().Create(
                solution.OverallWallTime)
                .GetValueForOutputContext();

            // x(i, s)
            Interfaces.Results.Common.DaySurgeonNumberBlockAssignments.Ix x = QMIPModel.x.GetElementsAt(
                resultElementsAbstractFactory.CreatexResultElementFactory(),
                resultsAbstractFactory.CreatexFactory(),
                QMIPModel.si,
                QMIPModel.A);

            this.DaySurgeonNumberBlockAssignments = x
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory(),
                QMIPModel.i,
                QMIPModel.s);

            // μ(i)
            Interfaces.Results.Common.DayBedOccupancyMeans.Iμ μ = QMIPModel.μ.GetElementsAt(
                resultElementsAbstractFactory.CreateμResultElementFactory(),
                resultsAbstractFactory.CreateμFactory(),
                QMIPModel.i);

            this.DayBedOccupancyMeans = μ
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // Variance(i)
            Interfaces.Results.Common.DayBedOccupancyVariances.IVariance variance = QMIPModel.Variance.GetElementsAt(
                resultElementsAbstractFactory.CreateVarianceResultElementFactory(),
                resultsAbstractFactory.CreateVarianceFactory(),
                QMIPModel.i);

            this.DayBedOccupancyVariances = variance
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // EBS(i)
            Interfaces.Results.Common.DayExpectedBedShortages.IEBS EBS = calculationsAbstractFactory.CreateEBSCalculationFactory().Create()
                .Calculate(
                resultElementsAbstractFactory.CreateEBSResultElementFactory(),
                resultsAbstractFactory.CreateEBSFactory(),
                calculationsAbstractFactory.CreateEBSResultElementCalculationFactory().Create(),
                QMIPModel.i,
                QMIPModel.c,
                μ,
                variance);

            this.DayExpectedBedShortages = EBS
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // TEBS
            this.TotalExpectedBedShortage = calculationsAbstractFactory.CreateTEBSCalculationFactory().Create()
                .Calculate(
                resultsAbstractFactory.CreateTEBSFactory(),
                QMIPModel.i,
                EBS)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // SurgeonNumberAssignedDays(s)
            this.SurgeonNumberAssignedDays = calculationsAbstractFactory.CreateSurgeonNumberAssignedDaysCalculationFactory().Create()
                .Calculate(
                resultElementsAbstractFactory.CreateSurgeonNumberAssignedDaysResultElementFactory(),
                resultsAbstractFactory.CreateSurgeonNumberAssignedDaysFactory(),
                calculationsAbstractFactory.CreateSurgeonNumberAssignedDaysResultElementCalculationFactory().Create(),
                QMIPModel.s,
                x)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());
        }

        public INullableValue<decimal> BestBound { get; }

        public RedBlackTree<FhirDateTime, INullableValue<decimal>> DayExpectedBedShortages { get; }

        public INullableValue<decimal> Gap { get; }

        public long NumberOfExploredNodes { get; }

        public INullableValue<decimal> ObjectiveValue { get; }

        public TimeSpan OverallWallTime { get; }

        public RedBlackTree<Organization, INullableValue<int>> SurgeonNumberAssignedDays { get; }

        public INullableValue<decimal> TotalExpectedBedShortage { get; }

        public ImmutableList<Tuple<FhirDateTime, Organization, INullableValue<int>>> DaySurgeonNumberBlockAssignments { get; }

        public RedBlackTree<FhirDateTime, INullableValue<decimal>> DayBedOccupancyMeans { get; }

        public RedBlackTree<FhirDateTime, INullableValue<decimal>> DayBedOccupancyVariances { get; }
    }
}