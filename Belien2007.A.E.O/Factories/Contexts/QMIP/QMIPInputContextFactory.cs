namespace Belien2007.A.E.O.Factories.Contexts.QMIP
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Classes.Contexts.QMIP;
    using Belien2007.A.E.O.Interfaces.Contexts.QMIP;
    using Belien2007.A.E.O.InterfacesFactories.Contexts.QMIP;

    internal sealed class QMIPInputContextFactory : IQMIPInputContextFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public QMIPInputContextFactory()
        {
        }

        public IQMIPInputContext Create(
            ImmutableList<INullableValue<int>> lengthOfStayDays,
            ImmutableList<KeyValuePair<INullableValue<int>, FhirDateTime>> planningHorizon,
            Bundle surgeons,
            ImmutableList<KeyValuePair<FhirDateTime, INullableValue<bool>>> activePeriods,
            ImmutableList<KeyValuePair<FhirDateTime, INullableValue<int>>> dayNumberTimeBlocks,
            ImmutableList<KeyValuePair<FhirDateTime, INullableValue<int>>> dayBedCapacities,
            ImmutableList<KeyValuePair<Organization, INullableValue<int>>> surgeonLengthOfStayMaximums,
            ImmutableList<KeyValuePair<Organization, INullableValue<int>>> surgeonMaximumNumberPatients,
            ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<decimal>>> surgeonDayLengthOfStayProbabilities,
            ImmutableList<KeyValuePair<Organization, INullableValue<int>>> surgeonNumberTimeBlocks)
        {
            IQMIPInputContext context = null;

            try
            {
                context = new QMIPInputContext(
                    lengthOfStayDays,
                    planningHorizon,
                    surgeons,
                    activePeriods,
                    dayNumberTimeBlocks,
                    dayBedCapacities,
                    surgeonLengthOfStayMaximums,
                    surgeonMaximumNumberPatients,
                    surgeonDayLengthOfStayProbabilities,
                    surgeonNumberTimeBlocks);
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