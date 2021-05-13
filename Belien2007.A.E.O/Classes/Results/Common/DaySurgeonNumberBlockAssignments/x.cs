namespace Belien2007.A.E.O.Classes.Results.Common.DaySurgeonNumberBlockAssignments
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ResultElements.Common.DaySurgeonNumberBlockAssignments;
    using Belien2007.A.E.O.Interfaces.Results.Common.DaySurgeonNumberBlockAssignments;
    using Belien2007.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class x : Ix
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public x(
            ImmutableList<IxResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IxResultElement> Value { get; }

        public int GetElementAtAsint(
            IiIndexElement iIndexElement,
            IsIndexElement sIndexElement)
        {
            return this.Value
                .Where(x => x.iIndexElement == iIndexElement && x.sIndexElement == sIndexElement)
                .Select(x => x.Value)
                .SingleOrDefault();
        }

        public ImmutableList<Tuple<FhirDateTime, Organization, INullableValue<int>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            return this.Value
                .Select(
                i => Tuple.Create(
                    i.iIndexElement.Value,
                    i.sIndexElement.Value,
                    nullableValueFactory.Create<int>(
                        i.Value)))
                .ToImmutableList();
        }
    }
}