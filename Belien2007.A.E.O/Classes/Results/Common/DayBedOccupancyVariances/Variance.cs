namespace Belien2007.A.E.O.Classes.Results.Common.DayBedOccupancyVariances
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ResultElements.Common.DayBedOccupancyVariances;
    using Belien2007.A.E.O.Interfaces.Results.Common.DayBedOccupancyVariances;
    using Belien2007.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class Variance : IVariance
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Variance(
            ImmutableList<IVarianceResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IVarianceResultElement> Value { get; }

        public decimal GetElementAtAsdecimal(
            IiIndexElement iIndexElement)
        {
            return this.Value
                .Where(x => x.iIndexElement == iIndexElement)
                .Select(x => x.Value)
                .SingleOrDefault();
        }

        public RedBlackTree<FhirDateTime, INullableValue<decimal>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            RedBlackTree<FhirDateTime, INullableValue<decimal>> redBlackTree = new RedBlackTree<FhirDateTime, INullableValue<decimal>>();

            foreach (IVarianceResultElement varianceResultElement in this.Value)
            {
                redBlackTree.Add(
                    varianceResultElement.iIndexElement.Value,
                    nullableValueFactory.Create<decimal>(
                        varianceResultElement.Value));
            }

            return redBlackTree;
        }
    }
}