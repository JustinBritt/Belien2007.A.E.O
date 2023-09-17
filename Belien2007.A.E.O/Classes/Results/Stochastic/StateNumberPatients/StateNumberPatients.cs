namespace Belien2007.A.E.O.Classes.Results.Stochastic.StateNumberPatients
{
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.ResultElements.Stochastic.StateNumberPatients;
    using Belien2007.A.E.O.Interfaces.Results.Stochastic.StateNumberPatients;
    using Belien2007.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class StateNumberPatients : IStateNumberPatients
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public StateNumberPatients(
            ImmutableList<IStateNumberPatientsResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IStateNumberPatientsResultElement> Value { get; }

        public RedBlackTree<INullableValue<int>, INullableValue<int>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            RedBlackTree<INullableValue<int>, INullableValue<int>> redBlackTree = new RedBlackTree<INullableValue<int>, INullableValue<int>>();

            foreach (IStateNumberPatientsResultElement stateNumberPatientsResultElement in this.Value)
            {
                redBlackTree.Add(
                    stateNumberPatientsResultElement.kIndexElement.Value,
                    nullableValueFactory.Create<int>(
                        stateNumberPatientsResultElement.Value));
            }

            return redBlackTree;
        }
    }
}