namespace Belien2007.A.E.O.Classes.Models.MIP2
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using OPTANO.Modeling.Optimization;
    using OPTANO.Modeling.Optimization.Enums;

    using Belien2007.A.E.O.InterfacesAbstractFactories;

    using Belien2007.A.E.O.Interfaces.Contexts.MIP2;
    using Belien2007.A.E.O.Interfaces.CrossJoins.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.Interfaces.Models.MIP2;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.ActivePeriods;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.DayBedCapacities;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.DayNumberAvailableTimeBlocks;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonDayLengthOfStayProbabilities;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonLengthOfStayMaximums;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonMaximumNumberPatients;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonNumberTimeBlocks;
    using Belien2007.A.E.O.Interfaces.Parameters.MIP2.Weights;
    using Belien2007.A.E.O.Interfaces.Variables.Common;
    using Belien2007.A.E.O.Interfaces.Variables.MIP2;

    internal sealed class MIP2Model : IMIP2Model
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public MIP2Model(
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
            IMIP2InputContext context)
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
                this.Context.LengthOfStayDays
                .Select(x => indexElementsAbstractFactory.Created1IndexElementFactory().Create(x))
                .ToImmutableList());

            // d2
            this.d2 = indicesAbstractFactory.Created2Factory().Create(
                this.Context.LengthOfStayDays
                .Select(x => indexElementsAbstractFactory.Created2IndexElementFactory().Create(x))
                .ToImmutableList());

            // i
            this.i = indicesAbstractFactory.CreateiFactory().Create(
                this.Context.PlanningHorizon
                .Select(x => indexElementsAbstractFactory.CreateiIndexElementFactory().Create(
                    x.Key.Value.Value,
                    x.Value))
                .ToImmutableList());

            // j
            this.j = indicesAbstractFactory.CreatejFactory().Create(
                this.Context.PlanningHorizon
                .Select(x => indexElementsAbstractFactory.CreatejIndexElementFactory().Create(
                    x.Key.Value.Value,
                    x.Value))
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
                .SelectMany(b => this.i.Value, (a, b) => crossJoinElementsAbstractFactory.CreatesiCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // sj
            this.sj = crossJoinsAbstractFactory.CreatesjFactory().Create(
                this.s.Value.Values
                .SelectMany(b => this.j.Value, (a, b) => crossJoinElementsAbstractFactory.CreatesjCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // sjd
            this.sjd = crossJoinsAbstractFactory.CreatesjdFactory().Create(
                this.s.Value.Values
                .SelectMany(b => this.j.Value, (a, b) => crossJoinElementsAbstractFactory.CreatesjCrossJoinElementFactory().Create(a, b))
                .SelectMany(b => this.d.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreatesjdCrossJoinElementFactory().Create(a.sIndexElement, a.jIndexElement, b))
                .ToImmutableList());

            // sjd1d2
            this.sjd1d2 = crossJoinsAbstractFactory.Createsjd1d2Factory().Create(
                this.s.Value.Values
                .SelectMany(b => this.j.Value, (a, b) => crossJoinElementsAbstractFactory.CreatesjCrossJoinElementFactory().Create(a, b))
                .SelectMany(b => this.d1.Value, (a, b) => crossJoinElementsAbstractFactory.Createsjd1CrossJoinElementFactory().Create(a.sIndexElement, a.jIndexElement, b))
                .SelectMany(b => this.d2.Value, (a, b) => crossJoinElementsAbstractFactory.Createsjd1d2CrossJoinElementFactory().Create(a.sIndexElement, a.jIndexElement, a.d1IndexElement, b))
                .ToImmutableList());

            // Parameters

            // A
            this.A = parametersAbstractFactory.CreateAFactory().Create(
                this.Context.ActivePeriods
                .Select(x => parameterElementsAbstractFactory.CreateAParameterElementFactory().Create(
                    this.i.GetElementAt(x.Key),
                    x.Value))
                .ToImmutableList());

            // b(i)
            this.b = parametersAbstractFactory.CreatebFactory().Create(
                this.Context.DayNumberTimeBlocks
                .Select(x => parameterElementsAbstractFactory.CreatebParameterElementFactory().Create(
                    this.i.GetElementAt(x.Key),
                    x.Value))
                .ToImmutableList());

            // c(i)
            this.c = parametersAbstractFactory.CreatecFactory().Create(
                this.Context.DayBedCapacities
                .Select(x => parameterElementsAbstractFactory.CreatecParameterElementFactory().Create(
                    this.i.GetElementAt(x.Key),
                    x.Value))
                .ToImmutableList());

            // m(s)
            this.m = parametersAbstractFactory.CreatemFactory().Create(
                this.Context.SurgeonLengthOfStayMaximums
                .Select(x => parameterElementsAbstractFactory.CreatemParameterElementFactory().Create(
                    this.s.GetElementAt(x.Key),
                    x.Value))
                .ToImmutableList());

            // n(s)
            this.n = parametersAbstractFactory.CreateCommonnFactory().Create(
                this.Context.SurgeonMaximumNumberPatients
                .Select(x => parameterElementsAbstractFactory.CreateCommonnParameterElementFactory().Create(
                    this.s.GetElementAt(x.Key),
                    x.Value))
                .ToImmutableList());

            // p(s, d)
            this.p = parametersAbstractFactory.CreatepFactory().Create(
                this.Context.SurgeonDayLengthOfStayProbabilities
                .Select(x => parameterElementsAbstractFactory.CreatepParameterElementFactory().Create(
                    this.s.GetElementAt(x.Item1),
                    this.d.GetElementAt(x.Item2),
                    x.Item3))
                .ToImmutableList());

            // r(s)
            this.r = parametersAbstractFactory.CreaterFactory().Create(
                this.Context.SurgeonNumberTimeBlocks
                .Select(x => parameterElementsAbstractFactory.CreaterParameterElementFactory().Create(
                    this.s.GetElementAt(x.Key),
                    x.Value))
                .ToImmutableList());

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
                    indexSet1: this.i.Value.Where(w => A.GetElementAtAsint(w) == 1), 
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
                    indexSet1: this.i.Value,
                    lowerBoundGenerator: (a) => 0,
                    upperBoundGenerator: (a) => double.MaxValue, 
                    variableTypeGenerator: (a) => VariableType.Continuous)); 

            // Variance(i)
            this.Variance = variablesAbstractFactory.CreateVarianceFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.i.Value, 
                    lowerBoundGenerator: (a) => 0, 
                    upperBoundGenerator: (a) => double.MaxValue, 
                    variableTypeGenerator: (a) => VariableType.Continuous));

            // Constraints

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
                this.i.Value
                .Where(w => A.GetElementAtAsint(w) == 1)
                .Select(
                    w => constraintElementsAbstractFactory.Create_Constraints23_38_317_44_ConstraintElement_Factory().Create(
                        w,
                        this.s,
                        this.b,
                        this.x)
                    .Value));

            // Constraints (3.18)
            this.Model.AddConstraints(
                this.i.Value
                .Select(
                    w => constraintElementsAbstractFactory.CreateConstraints318ConstraintElementFactory().Create(
                        w,
                        this.d,
                        this.i,
                        this.j,
                        this.s,
                        this.sj,
                        this.A,
                        this.m,
                        this.n,
                        this.p,
                        this.x,
                        this.μ)
                    .Value));

            // Constraints (3.19)
            this.Model.AddConstraints(
                this.i.Value
                .Select(
                    w => constraintElementsAbstractFactory.CreateConstraints319ConstraintElementFactory().Create(
                        w,
                        this.d,
                        this.i,
                        this.j,
                        this.s,
                        this.sj,
                        this.A,
                        this.m,
                        this.n,
                        this.p,
                        this.x,
                        this.Variance)
                    .Value));

            // Constraints (3.20)
            this.Model.AddConstraints(
                this.i.Value
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
        public IMIP2InputContext Context { get; }

        /// <summary>
        /// Gets the Model instance.
        /// </summary>
        public Model Model { get; }

        public Interfaces.Indices.Common.Id d { get; }

        public Id1 d1 { get; }

        public Id2 d2 { get; }

        public Ii i { get; }

        public Ij j { get; }

        public Is s { get; }

        public Isi si { get; }

        public Isj sj { get; }

        public Isjd sjd { get; }

        public Isjd1d2 sjd1d2 { get; }

        public IA A { get; }

        public Ib b { get; }

        public Ic c { get; }

        public Im m { get; }

        public ICommonn n { get; }

        public Ip p { get; }

        public Ir r { get; }

        public IwMean wMean { get; }

        public IwVariance wVariance { get; }

        public Ix x { get; }

        public Iγ γ { get; }

        public Iμ μ { get; }

        public IVariance Variance { get; }
    }
}