namespace Belien2007.A.E.O.Classes.Results.Stochastic.SurgeonStateNumberPatients
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Stochastic;
    using Belien2007.A.E.O.Interfaces.ResultElements.Stochastic.SurgeonStateNumberPatients;
    using Belien2007.A.E.O.Interfaces.Results.Stochastic.SurgeonStateNumberPatients;
    using Belien2007.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    
    internal sealed class SurgeonStateNumberPatients : ISurgeonStateNumberPatients
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonStateNumberPatients(
            ImmutableList<ISurgeonStateNumberPatientsResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<ISurgeonStateNumberPatientsResultElement> Value { get; }

        public ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory,
            Ik k,
            Is s)
        {
            return this.Value
                .Select(
                i => Tuple.Create(
                    i.sIndexElement.Value,
                    (INullableValue<int>)i.kIndexElement.Value,
                    nullableValueFactory.Create<int>(
                        i.Value)))
                .ToImmutableList();
        }
    }
}