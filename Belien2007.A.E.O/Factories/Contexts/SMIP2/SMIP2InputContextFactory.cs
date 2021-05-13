namespace Belien2007.A.E.O.Factories.Contexts.SMIP2
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

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
            ImmutableList<PositiveInt> lengthOfStayDays,
            ImmutableList<KeyValuePair<PositiveInt, FhirDateTime>> planningHorizon,
            ImmutableList<PositiveInt> states,
            Bundle surgeons,
            ImmutableList<KeyValuePair<FhirDateTime, FhirBoolean>> activePeriods,
            ImmutableList<KeyValuePair<FhirDateTime, PositiveInt>> dayNumberTimeBlocks,
            ImmutableList<KeyValuePair<FhirDateTime, PositiveInt>> dayBedCapacities,
            ImmutableList<Tuple<Organization, PositiveInt, FhirDecimal>> surgeonStateProbabilities,
            ImmutableList<KeyValuePair<Organization, PositiveInt>> surgeonLengthOfStayMaximums,
            ImmutableList<Tuple<Organization, PositiveInt, PositiveInt>> surgeonStateMaximumNumberPatients,
            ImmutableList<Tuple<Organization, PositiveInt, FhirDecimal>> surgeonDayLengthOfStayProbabilities,
            ImmutableList<KeyValuePair<Organization, PositiveInt>> surgeonNumberStates,
            ImmutableList<KeyValuePair<Organization, PositiveInt>> surgeonNumberTimeBlocks,
            FhirDecimal meanWeight,
            FhirDecimal varianceWeight)
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
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return context;
        }
    }
}