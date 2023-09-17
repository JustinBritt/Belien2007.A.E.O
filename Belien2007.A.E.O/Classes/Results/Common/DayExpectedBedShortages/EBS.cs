namespace Belien2007.A.E.O.Classes.Results.Common.DayExpectedBedShortages
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ResultElements.Common.DayExpectedBedShortages;
    using Belien2007.A.E.O.Interfaces.Results.Common.DayExpectedBedShortages;
    using Belien2007.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class EBS : IEBS
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public EBS(
            ImmutableList<IEBSResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IEBSResultElement> Value { get; }

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
            RedBlackTree<FhirDateTime, INullableValue<decimal>> redBlackTree = new RedBlackTree<FhirDateTime, INullableValue<decimal>>(
                new Belien2007.A.E.O.Classes.Comparers.FhirDateTimeComparer());

            foreach (IEBSResultElement EBSResultElement in this.Value)
            {
                redBlackTree.Add(
                    EBSResultElement.iIndexElement.Value,
                    nullableValueFactory.Create<decimal>(
                        EBSResultElement.Value));
            }

            return redBlackTree;
        }
    }
}