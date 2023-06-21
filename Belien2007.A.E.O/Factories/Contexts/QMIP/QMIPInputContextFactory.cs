namespace Belien2007.A.E.O.Factories.Contexts.QMIP
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

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
            ImmutableSortedSet<INullableValue<int>> lengthOfStayDays,
            ImmutableList<KeyValuePair<INullableValue<int>, FhirDateTime>> planningHorizon,
            Bundle surgeons,
            ImmutableList<KeyValuePair<FhirDateTime, INullableValue<bool>>> activePeriods,
            RedBlackTree<FhirDateTime, INullableValue<int>> dayNumberTimeBlocks,
            RedBlackTree<FhirDateTime, INullableValue<int>> dayBedCapacities,
            RedBlackTree<Organization, INullableValue<int>> surgeonLengthOfStayMaximums,
            RedBlackTree<Organization, INullableValue<int>> surgeonMaximumNumberPatients,
            ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<decimal>>> surgeonDayLengthOfStayProbabilities,
            RedBlackTree<Organization, INullableValue<int>> surgeonNumberTimeBlocks)
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