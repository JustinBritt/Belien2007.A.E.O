namespace Belien2007.A.E.O.Classes.Models.SMIP2
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using OPTANO.Modeling.Optimization;
    using OPTANO.Modeling.Optimization.Enums;

    using Belien2007.A.E.O.InterfacesAbstractFactories;
    using Belien2007.A.E.O.Interfaces.Contexts.SMIP2;
    using Belien2007.A.E.O.Interfaces.CrossJoins.Common;
    using Belien2007.A.E.O.Interfaces.CrossJoins.Stochastic;
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Stochastic;
    using Belien2007.A.E.O.Interfaces.Models.SMIP2;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.ActivePeriods;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.DayBedCapacities;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.DayNumberAvailableTimeBlocks;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonDayLengthOfStayProbabilities;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonLengthOfStayMaximums;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonNumberTimeBlocks;
    using Belien2007.A.E.O.Interfaces.Parameters.MIP2.Weights;
    using Belien2007.A.E.O.Interfaces.Parameters.Stochastic.SurgeonNumberStates;
    using Belien2007.A.E.O.Interfaces.Parameters.Stochastic.SurgeonStateMaximumNumberPatients;
    using Belien2007.A.E.O.Interfaces.Parameters.Stochastic.SurgeonStateProbabilities;
    using Belien2007.A.E.O.Interfaces.Variables.Common;
    using Belien2007.A.E.O.Interfaces.Variables.MIP2;
    using Belien2007.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class SMIP2Model : ISMIP2Model
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SMIP2Model(
            IComparersAbstractFactory comparersAbstractFactory,
            IConstraintElementsAbstractFactory constraintElementsAbstractFactory,
            IConstraintsAbstractFactory constraintsAbstractFactory,
            ICrossJoinElementsAbstractFactory crossJoinElementsAbstractFactory,
            ICrossJoinsAbstractFactory crossJoinsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IIndexElementsAbstractFactory indexElementsAbstractFactory,
            IIndicesAbstractFactory indicesAbstractFactory,
            IObjectiveFunctionsAbstractFactory objectiveFunctionsAbstractFactory,
            IParameterElementsAbstractFactory parameterElementsAbstractFactory,
            IParametersAbstractFactory parametersAbstractFactory,
            IVariablesAbstractFactory variablesAbstractFactory,
            ISMIP2InputContext context)
        {
            this.Context = context;

            this.Model = dependenciesAbstractFactory.CreateModelFactory().Create();

            // Indices

            // d
            this.d = indicesAbstractFactory.CreatedFactory().Create(
                comparersAbstractFactory.CreateNullableValueintComparerFactory().Create(),
                this.Context.LengthOfStayDays
                .Select(x => indexElementsAbstractFactory.CreatedIndexElementFactory().Create(x))
                .ToImmutableList());

            // d1
            this.d1 = indicesAbstractFactory.Created1Factory().Create(
                comparersAbstractFactory.CreateNullableValueintComparerFactory().Create(),
                this.Context.LengthOfStayDays
                .Select(x => indexElementsAbstractFactory.Created1IndexElementFactory().Create(x))
                .ToImmutableList());

            // d2
            this.d2 = indicesAbstractFactory.Created2Factory().Create(
                comparersAbstractFactory.CreateNullableValueintComparerFactory().Create(),
                this.Context.LengthOfStayDays
                .Select(x => indexElementsAbstractFactory.Created2IndexElementFactory().Create(x))
                .ToImmutableList());

            // i
            IPlanningHorizonVisitor<INullableValue<int>, FhirDateTime> planningHorizonVisitor = new Belien2007.A.E.O.Visitors.Contexts.PlanningHorizonVisitor<INullableValue<int>, FhirDateTime>(
                indexElementsAbstractFactory.CreateiIndexElementFactory(),
                indexElementsAbstractFactory.CreatejIndexElementFactory(),
                comparersAbstractFactory.CreateFhirDateTimeComparerFactory().Create());

            this.Context.PlanningHorizon.AcceptVisitor(
                planningHorizonVisitor);

            this.i = indicesAbstractFactory.CreateiFactory().Create(
                planningHorizonVisitor.iRedBlackTree);

            // j
            this.j = indicesAbstractFactory.CreatejFactory().Create(
                planningHorizonVisitor.jRedBlackTree);

            // k
            this.k = indicesAbstractFactory.CreatekFactory().Create(
                comparersAbstractFactory.CreateNullableValueintComparerFactory().Create(),
                this.Context.States
                .Select(x => indexElementsAbstractFactory.CreatekIndexElementFactory().Create(x))
                .ToImmutableList());

            // s
            this.s = indicesAbstractFactory.CreatesFactory().Create(
                comparersAbstractFactory.CreateOrganizationComparerFactory().Create(),
                this.Context.Surgeons
                .Entry
                .Where(x => x.Resource is Organization)
                .Select(x => indexElementsAbstractFactory.CreatesIndexElementFactory().Create((Organization)x.Resource))
                .ToImmutableList());

            // Cross joins

            // si
            this.si = crossJoinsAbstractFactory.CreatesiFactory().Create(
                this.s.Value.Values
                .SelectMany(b => this.i.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreatesiCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // sj
            this.sj = crossJoinsAbstractFactory.CreatesjFactory().Create(
                this.s.Value.Values
                .SelectMany(b => this.j.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreatesjCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // sjd
            this.sjd = crossJoinsAbstractFactory.CreatesjdFactory().Create(
                this.s.Value.Values
                .SelectMany(b => this.j.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreatesjCrossJoinElementFactory().Create(a, b))
                .SelectMany(b => this.d.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreatesjdCrossJoinElementFactory().Create(a.sIndexElement, a.jIndexElement, b))
                .ToImmutableList());

            // sjd1d2
            this.sjd1d2 = crossJoinsAbstractFactory.Createsjd1d2Factory().Create(
                this.s.Value.Values
                .SelectMany(b => this.j.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreatesjCrossJoinElementFactory().Create(a, b))
                .SelectMany(b => this.d1.Value.Values, (a, b) => crossJoinElementsAbstractFactory.Createsjd1CrossJoinElementFactory().Create(a.sIndexElement, a.jIndexElement, b))
                .SelectMany(b => this.d2.Value.Values, (a, b) => crossJoinElementsAbstractFactory.Createsjd1d2CrossJoinElementFactory().Create(a.sIndexElement, a.jIndexElement, a.d1IndexElement, b))
                .ToImmutableList());

            // sk
            this.sk = crossJoinsAbstractFactory.CreateskFactory().Create(
                this.s.Value.Values
                .SelectMany(b => this.k.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreateskCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // Parameters

            // A
            IActivePeriodsVisitor<FhirDateTime, INullableValue<bool>> activePeriodsVisitor = new Belien2007.A.E.O.Visitors.Contexts.ActivePeriodsVisitor<FhirDateTime, INullableValue<bool>>(
                parameterElementsAbstractFactory.CreateAParameterElementFactory(),
                this.i);

            this.Context.ActivePeriods.AcceptVisitor(
                activePeriodsVisitor);

            this.A = parametersAbstractFactory.CreateAFactory().Create(
                activePeriodsVisitor.RedBlackTree);

            // b(i)
            IDayNumberTimeBlocksVisitor<FhirDateTime, INullableValue<int>> dayNumberTimeBlocksVisitor = new Belien2007.A.E.O.Visitors.Contexts.DayNumberTimeBlocksVisitor<FhirDateTime, INullableValue<int>>(
                parameterElementsAbstractFactory.CreatebParameterElementFactory(),
                this.i);

            this.Context.DayNumberTimeBlocks.AcceptVisitor(
                dayNumberTimeBlocksVisitor);

            this.b = parametersAbstractFactory.CreatebFactory().Create(
                dayNumberTimeBlocksVisitor.RedBlackTree);

            // c(i)
            IDayBedCapacitiesVisitor<FhirDateTime, INullableValue<int>> dayBedCapacitiesVisitor = new Belien2007.A.E.O.Visitors.Contexts.DayBedCapacitiesVisitor<FhirDateTime, INullableValue<int>>(
                parameterElementsAbstractFactory.CreatecParameterElementFactory(),
                this.i);

            this.Context.DayBedCapacities.AcceptVisitor(
                dayBedCapacitiesVisitor);

            this.c = parametersAbstractFactory.CreatecFactory().Create(
                dayBedCapacitiesVisitor.RedBlackTree);

            // h(s, k)
            ISurgeonStateProbabilitiesOuterVisitor<Organization, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> surgeonStateProbabilitiesOuterVisitor = new Belien2007.A.E.O.Visitors.Contexts.SurgeonStateProbabilitiesOuterVisitor<Organization, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>(
                parameterElementsAbstractFactory.CreatehParameterElementFactory(),
                this.k,
                this.s);

            this.Context.SurgeonStateProbabilities.AcceptVisitor(
                surgeonStateProbabilitiesOuterVisitor);

            this.h = parametersAbstractFactory.CreatehFactory().Create(
                surgeonStateProbabilitiesOuterVisitor.RedBlackTree);

            // m(s)
            ISurgeonLengthOfStayMaximumsVisitor<Organization, INullableValue<int>> surgeonLengthOfStayMaximumsVisitor = new Belien2007.A.E.O.Visitors.Contexts.SurgeonLengthOfStayMaximumsVisitor<Organization, INullableValue<int>>(
                parameterElementsAbstractFactory.CreatemParameterElementFactory(),
                this.s);

            this.Context.SurgeonLengthOfStayMaximums.AcceptVisitor(
                surgeonLengthOfStayMaximumsVisitor);

            this.m = parametersAbstractFactory.CreatemFactory().Create(
                surgeonLengthOfStayMaximumsVisitor.RedBlackTree);

            // n(s, k)
            ISurgeonStateMaximumNumberPatientsOuterVisitor<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>> surgeonStateMaximumNumberPatientsOuterVisitor = new Belien2007.A.E.O.Visitors.Contexts.SurgeonStateMaximumNumberPatientsOuterVisitor<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>>(
                parameterElementsAbstractFactory.CreateStochasticnParameterElementFactory(),
                this.k,
                this.s);

            this.Context.SurgeonStateMaximumNumberPatients.AcceptVisitor(
                surgeonStateMaximumNumberPatientsOuterVisitor);

            this.n = parametersAbstractFactory.CreateStochasticnFactory().Create(
                surgeonStateMaximumNumberPatientsOuterVisitor.RedBlackTree);

            // p(s, d)
            ISurgeonDayLengthOfStayProbabilitiesOuterVisitor<Organization, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> surgeonDayLengthOfStayProbabilitiesOuterVisitor = new Belien2007.A.E.O.Visitors.Contexts.SurgeonDayLengthOfStayProbabilitiesOuterVisitor<Organization, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>(
                parameterElementsAbstractFactory.CreatepParameterElementFactory(),
                this.d,
                this.s);

            this.Context.SurgeonDayLengthOfStayProbabilities.AcceptVisitor(
                surgeonDayLengthOfStayProbabilitiesOuterVisitor);

            this.p = parametersAbstractFactory.CreatepFactory().Create(
                surgeonDayLengthOfStayProbabilitiesOuterVisitor.RedBlackTree);

            // q(s)
            ISurgeonNumberStatesVisitor<Organization, INullableValue<int>> surgeonNumberStatesVisitor = new Belien2007.A.E.O.Visitors.Contexts.SurgeonNumberStatesVisitor<Organization, INullableValue<int>>(
                parameterElementsAbstractFactory.CreateqParameterElementFactory(),
                this.s);

            this.Context.SurgeonNumberStates.AcceptVisitor(
                surgeonNumberStatesVisitor);

            this.q = parametersAbstractFactory.CreateqFactory().Create(
                surgeonNumberStatesVisitor.RedBlackTree);

            // r(s)
            ISurgeonNumberTimeBlocksVisitor<Organization, INullableValue<int>> surgeonNumberTimeBlocksVisitor = new Belien2007.A.E.O.Visitors.Contexts.SurgeonNumberTimeBlocksVisitor<Organization, INullableValue<int>>(
                parameterElementsAbstractFactory.CreaterParameterElementFactory(),
                this.s);

            this.Context.SurgeonNumberTimeBlocks.AcceptVisitor(
                surgeonNumberTimeBlocksVisitor);

            this.r = parametersAbstractFactory.CreaterFactory().Create(
                surgeonNumberTimeBlocksVisitor.RedBlackTree);

            // wMean
            this.wMean = parametersAbstractFactory.CreatewMeanFactory().Create(
                this.Context.MeanWeight);

            // wVariance
            this.wVariance = parametersAbstractFactory.CreatewVarianceFactory().Create(
                this.Context.VarianceWeight);

            // Variables

            // x(i, s)
            this.x = variablesAbstractFactory.CreatexFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.i.Value.Values.Where(w => A.GetElementAtAsint(w) == 1), 
                    indexSet2: this.s.Value.Values, 
                    lowerBoundGenerator: (a, b) => 0, 
                    upperBoundGenerator: (a, b) =>
                    Math.Min(
                        this.b.GetElementAtAsint(a),
                        this.r.GetElementAtAsint(b)), 
                    variableTypeGenerator: (a, b) => VariableType.Integer)); 

            // γ
            this.γ = variablesAbstractFactory.CreateγFactory().Create(
                dependenciesAbstractFactory.CreateVariableFactory().Create(
                    lowerbound: 0, 
                    type: VariableType.Continuous,
                    upperbound: double.MaxValue)); 

            this.Model.AddVariable(
                this.γ.Value);

            // μ(i)
            this.μ = variablesAbstractFactory.CreateμFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.i.Value.Values, 
                    lowerBoundGenerator: (a) => 0, 
                    upperBoundGenerator: (a) => double.MaxValue,
                    variableTypeGenerator: (a) => VariableType.Continuous)); 

            // Variance(i)
            this.Variance = variablesAbstractFactory.CreateVarianceFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.i.Value.Values, 
                    lowerBoundGenerator: (a) => 0, 
                    upperBoundGenerator: (a) => double.MaxValue, 
                    variableTypeGenerator: (a) => VariableType.Continuous)); 
 
            // Constraints (3.16)
            this.Model.AddConstraints(
                this.s.Value.Values
                .Select(
                    w => constraintElementsAbstractFactory.Create_Constraints22_37_316_43_ConstraintElement_Factory().Create(
                        w,
                        this.i,
                        this.A,
                        this.r,
                        this.x)
                    .Value));

            // Constraints (3.17)
            this.Model.AddConstraints(
                this.i.Value.Values
                .Where(w => A.GetElementAtAsint(w) == 1)
                .Select(
                    w => constraintElementsAbstractFactory.Create_Constraints23_38_317_44_ConstraintElement_Factory().Create(
                        w,
                        this.s,
                        this.b,
                        this.x)
                    .Value));

            // Constraints μ (3.18 but using ExpectedValue(U(i, j, s)) from 3.25 and 3.26)
            this.Model.AddConstraints(
                this.i.Value.Values
                .Select(
                    w => constraintElementsAbstractFactory.CreateConstraintsμConstraintElementFactory().Create(
                        w,
                        this.d,
                        this.i,
                        this.j,
                        this.k,
                        this.s,
                        this.sj,
                        this.A,
                        this.h,
                        this.m,
                        this.n,
                        this.p,
                        this.x,
                        this.μ)
                    .Value));

            // Constraints Variance (3.19 but using Variance(U(i, j, s)) from 3.27)
            this.Model.AddConstraints(
                this.i.Value.Values
                .Select(
                    w => constraintElementsAbstractFactory.CreateSMIP2ConstraintsVarianceConstraintElementFactory().Create(
                        w,
                        this.d,
                        this.i,
                        this.j,
                        this.k,
                        this.s,
                        this.sj,
                        this.A,
                        this.h,
                        this.m,
                        this.n,
                        this.p,
                        this.q,
                        this.x,
                        this.Variance)
                    .Value));

            // Constraints (3.20)
            this.Model.AddConstraints(
                this.i.Value.Values
                .Select(
                    w => constraintElementsAbstractFactory.CreateConstraints320ConstraintElementFactory().Create(
                        w,
                        this.wMean,
                        this.wVariance,
                        this.γ,
                        this.μ,
                        this.Variance)
                    .Value));

            // Objective function (3.15)
            this.Model.AddObjective(
                objectiveFunctionsAbstractFactory.CreateMIP2ObjectiveFunctionFactory().Create(
                    dependenciesAbstractFactory.CreateObjectiveFactory(),
                    this.γ)
                .Value);
        }

        /// <summary>
        /// Gets the Context instance.
        /// </summary>
        public ISMIP2InputContext Context { get; }

        /// <summary>
        /// Gets the Model instance.
        /// </summary>
        public Model Model { get; }

        public Interfaces.Indices.Common.Id d { get; }

        public Id1 d1 { get; }

        public Id2 d2 { get; }

        public Ii i { get; }

        public Ij j { get; }

        public Ik k { get; }

        public Is s { get; }

        public Isi si { get; }

        public Isj sj { get; }

        public Isjd sjd { get; }

        public Isjd1d2 sjd1d2 { get; }

        public Isk sk { get; }

        public IA A { get; }

        public Ib b { get; }

        public Ic c { get; }

        public Ih h { get; }

        public Im m { get; }

        public IStochasticn n { get; }

        public Ip p { get; }

        public Iq q { get; }

        public Ir r { get; }

        public IwMean wMean { get; }

        public IwVariance wVariance { get; }

        public Ix x { get; }

        public Iγ γ { get; }

        public Iμ μ { get; }

        public IVariance Variance { get; }
    }
}