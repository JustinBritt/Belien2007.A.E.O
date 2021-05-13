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
            ImmutableList<PositiveInt> lengthOfStayDays,
            ImmutableList<KeyValuePair<PositiveInt, FhirDateTime>> planningHorizon,
            Bundle surgeons,
            ImmutableList<KeyValuePair<FhirDateTime, FhirBoolean>> activePeriods,
            ImmutableList<KeyValuePair<FhirDateTime, PositiveInt>> dayNumberTimeBlocks,
            ImmutableList<KeyValuePair<FhirDateTime, PositiveInt>> dayBedCapacities,
            ImmutableList<KeyValuePair<Organization, PositiveInt>> surgeonLengthOfStayMaximums,
            ImmutableList<KeyValuePair<Organization, PositiveInt>> surgeonMaximumNumberPatients,
            ImmutableList<Tuple<Organization, PositiveInt, FhirDecimal>> surgeonDayLengthOfStayProbabilities,
            ImmutableList<KeyValuePair<Organization, PositiveInt>> surgeonNumberTimeBlocks,
            FhirDecimal meanWeight,
            FhirDecimal varianceWeight)
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
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return context;
        }
    }
}