namespace Belien2007.A.E.O.Factories.Contexts.SMIP2
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Classes.Contexts.SMIP2;
    using Belien2007.A.E.O.Interfaces.Contexts.SMIP2;
    using Belien2007.A.E.O.InterfacesFactories.Contexts.SMIP2;

    internal sealed class SMIP2InputContextFactory : ISMIP2InputContextFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SMIP2InputContextFactory()
        {
        }

        public ISMIP2InputContext Create(
            ImmutableSortedSet<INullableValue<int>> lengthOfStayDays,
            ImmutableList<KeyValuePair<INullableValue<int>, FhirDateTime>> planningHorizon,
            ImmutableList<INullableValue<int>> states,
            Bundle surgeons,
            ImmutableList<KeyValuePair<FhirDateTime, INullableValue<bool>>> activePeriods,
            RedBlackTree<FhirDateTime, INullableValue<int>> dayNumberTimeBlocks,
            ImmutableList<KeyValuePair<FhirDateTime, INullableValue<int>>> dayBedCapacities,
            ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<decimal>>> surgeonStateProbabilities,
            ImmutableList<KeyValuePair<Organization, INullableValue<int>>> surgeonLengthOfStayMaximums,
            ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>>> surgeonStateMaximumNumberPatients,
            ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<decimal>>> surgeonDayLengthOfStayProbabilities,
            ImmutableList<KeyValuePair<Organization, INullableValue<int>>> surgeonNumberStates,
            ImmutableList<KeyValuePair<Organization, INullableValue<int>>> surgeonNumberTimeBlocks,
            INullableValue<decimal> meanWeight,
            INullableValue<decimal> varianceWeight)
        {
            ISMIP2InputContext context = null;

            try
            {
                context = new SMIP2InputContext(
                    lengthOfStayDays,
                    planningHorizon,
                    states,
                    surgeons,
                    activePeriods,
                    dayNumberTimeBlocks,
                    dayBedCapacities,
                    surgeonStateProbabilities,
                    surgeonLengthOfStayMaximums,
                    surgeonStateMaximumNumberPatients,
                    surgeonDayLengthOfStayProbabilities,
                    surgeonNumberStates,
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