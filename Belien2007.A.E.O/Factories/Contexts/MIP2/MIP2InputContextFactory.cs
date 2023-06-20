namespace Belien2007.A.E.O.Factories.Contexts.MIP2
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Classes.Contexts.MIP2;
    using Belien2007.A.E.O.Interfaces.Contexts.MIP2;
    using Belien2007.A.E.O.InterfacesFactories.Contexts.MIP2;

    internal sealed class MIP2InputContextFactory : IMIP2InputContextFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public MIP2InputContextFactory()
        {
        }

        public IMIP2InputContext Create(
            ImmutableSortedSet<INullableValue<int>> lengthOfStayDays,
            ImmutableList<KeyValuePair<INullableValue<int>, FhirDateTime>> planningHorizon,
            Bundle surgeons,
            ImmutableList<KeyValuePair<FhirDateTime, INullableValue<bool>>> activePeriods,
            ImmutableList<KeyValuePair<FhirDateTime, INullableValue<int>>> dayNumberTimeBlocks,
            ImmutableList<KeyValuePair<FhirDateTime, INullableValue<int>>> dayBedCapacities,
            ImmutableList<KeyValuePair<Organization, INullableValue<int>>> surgeonLengthOfStayMaximums,
            ImmutableList<KeyValuePair<Organization, INullableValue<int>>> surgeonMaximumNumberPatients,
            ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<decimal>>> surgeonDayLengthOfStayProbabilities,
            ImmutableList<KeyValuePair<Organization, INullableValue<int>>> surgeonNumberTimeBlocks,
            INullableValue<decimal> meanWeight,
            INullableValue<decimal> varianceWeight)
        {
            IMIP2InputContext context = null;

            try
            {
                context = new MIP2InputContext(
                    lengthOfStayDays,
                    planningHorizon,
                    surgeons,
                    activePeriods,
                    dayNumberTimeBlocks,
                    dayBedCapacities,
                    surgeonLengthOfStayMaximums,
                    surgeonMaximumNumberPatients,
                    surgeonDayLengthOfStayProbabilities,
                    surgeonNumberTimeBlocks,
                    meanWeight,
                    varianceWeight);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return context;
        }
    }
}