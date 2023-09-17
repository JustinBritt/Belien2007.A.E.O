namespace Belien2007.A.E.O.Classes.Contexts.SMIP2
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using OPTANO.Modeling.Optimization;

    using Belien2007.A.E.O.InterfacesAbstractFactories;
    using Belien2007.A.E.O.Interfaces.Contexts.SMIP2;
    using Belien2007.A.E.O.Interfaces.Models.SMIP2;
    using Belien2007.A.E.O.Interfaces.Results.Stochastic.SurgeonStateNumberPatients;

    internal sealed class SMIP2OutputContext : ISMIP2OutputContext
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SMIP2OutputContext(
            ICalculationsAbstractFactory calculationsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IResultElementsAbstractFactory resultElementsAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            ISMIP2Model SMIP2Model,
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
            Interfaces.Results.Common.DaySurgeonNumberBlockAssignments.Ix x = SMIP2Model.x.GetElementsAt(
                resultElementsAbstractFactory.CreatexResultElementFactory(),
                resultsAbstractFactory.CreatexFactory(),
                SMIP2Model.si,
                SMIP2Model.A);

            this.DaySurgeonNumberBlockAssignments = x
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory(),
                SMIP2Model.i,
                SMIP2Model.s);

            // γ
            this.BedOccupancyMaximalWeightedSum = resultsAbstractFactory.CreateγFactory().Create(
                (decimal)SMIP2Model.γ.Value.Value)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // μ(i)
            Interfaces.Results.Common.DayBedOccupancyMeans.Iμ μ = SMIP2Model.μ.GetElementsAt(
                resultElementsAbstractFactory.CreateμResultElementFactory(),
                resultsAbstractFactory.CreateμFactory(),
                SMIP2Model.i);

            this.DayBedOccupancyMeans = μ
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // Variance(i)
            Interfaces.Results.Common.DayBedOccupancyVariances.IVariance variance = SMIP2Model.Variance.GetElementsAt(
                resultElementsAbstractFactory.CreateVarianceResultElementFactory(),
                resultsAbstractFactory.CreateVarianceFactory(),
                SMIP2Model.i);

            this.DayBedOccupancyVariances = variance
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // EBS(i)
            Interfaces.Results.Common.DayExpectedBedShortages.IEBS EBS = calculationsAbstractFactory.CreateEBSCalculationFactory().Create()
                .Calculate(
                resultElementsAbstractFactory.CreateEBSResultElementFactory(),
                resultsAbstractFactory.CreateEBSFactory(),
                calculationsAbstractFactory.CreateEBSResultElementCalculationFactory().Create(),
                SMIP2Model.i,
                SMIP2Model.c,
                μ,
                variance);

            this.DayExpectedBedShortages = EBS
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // TEBS
            this.TotalExpectedBedShortage = calculationsAbstractFactory.CreateTEBSCalculationFactory().Create()
                .Calculate(
                resultsAbstractFactory.CreateTEBSFactory(),
                SMIP2Model.i,
                EBS)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // SurgeonNumberAssignedDays(s)
            this.SurgeonNumberAssignedDays = calculationsAbstractFactory.CreateSurgeonNumberAssignedDaysCalculationFactory().Create()
                .Calculate(
                resultElementsAbstractFactory.CreateSurgeonNumberAssignedDaysResultElementFactory(),
                resultsAbstractFactory.CreateSurgeonNumberAssignedDaysFactory(),
                calculationsAbstractFactory.CreateSurgeonNumberAssignedDaysResultElementCalculationFactory().Create(),
                SMIP2Model.s,
                x)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // SurgeonStateNumberPatients(s, k)
            ISurgeonStateNumberPatients surgeonStateNumberPatients = calculationsAbstractFactory.CreateSurgeonStateNumberPatientsCalculationFactory().Create()
                .Calculate(
                resultElementsAbstractFactory.CreateSurgeonStateNumberPatientsResultElementFactory(),
                resultsAbstractFactory.CreateSurgeonStateNumberPatientsFactory(),
                calculationsAbstractFactory.CreateSurgeonStateNumberPatientsResultElementCalculationFactory().Create(),
                SMIP2Model.i,
                SMIP2Model.sk,
                SMIP2Model.A,
                SMIP2Model.n,
                x);
            
            this.SurgeonStateNumberPatients = surgeonStateNumberPatients.GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // StateNumberPatients(k)
            this.StateNumberPatients = calculationsAbstractFactory.CreateStateNumberPatientsCalculationFactory().Create()
                .Calculate(
                resultElementsAbstractFactory.CreateStateNumberPatientsResultElementFactory(),
                resultsAbstractFactory.CreateStateNumberPatientsFactory(),
                calculationsAbstractFactory.CreateStateNumberPatientsResultElementCalculationFactory().Create(),
                SMIP2Model.k,
                surgeonStateNumberPatients)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());
        }

        public INullableValue<decimal> BestBound { get; }

        public RedBlackTree<FhirDateTime, INullableValue<decimal>> DayExpectedBedShortages { get; }

        public INullableValue<decimal> Gap { get; }

        public long NumberOfExploredNodes { get; }

        public INullableValue<decimal> ObjectiveValue { get; }

        public TimeSpan OverallWallTime { get; }

        public RedBlackTree<INullableValue<int>, INullableValue<int>> StateNumberPatients { get; }

        public RedBlackTree<Organization, INullableValue<int>> SurgeonNumberAssignedDays { get; }

        public ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>>> SurgeonStateNumberPatients { get; }

        public INullableValue<decimal> TotalExpectedBedShortage { get; }

        public ImmutableList<Tuple<FhirDateTime, Organization, INullableValue<int>>> DaySurgeonNumberBlockAssignments { get; }

        public INullableValue<decimal> BedOccupancyMaximalWeightedSum { get; }

        public RedBlackTree<FhirDateTime, INullableValue<decimal>> DayBedOccupancyMeans { get; }

        public RedBlackTree<FhirDateTime, INullableValue<decimal>> DayBedOccupancyVariances { get; }
    }
}