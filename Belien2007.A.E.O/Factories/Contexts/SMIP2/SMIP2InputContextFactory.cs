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
            RedBlackTree<INullableValue<int>, FhirDateTime> planningHorizon,
            ImmutableSortedSet<INullableValue<int>> states,
            Bundle surgeons,
            RedBlackTree<FhirDateTime, INullableValue<bool>> activePeriods,
            RedBlackTree<FhirDateTime, INullableValue<int>> dayNumberTimeBlocks,
            RedBlackTree<FhirDateTime, INullableValue<int>> dayBedCapacities,
            RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> surgeonStateProbabilities,
            RedBlackTree<Organization, INullableValue<int>> surgeonLengthOfStayMaximums,
            ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>>> surgeonStateMaximumNumberPatients,
            RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> surgeonDayLengthOfStayProbabilities,
            RedBlackTree<Organization, INullableValue<int>> surgeonNumberStates,
            RedBlackTree<Organization, INullableValue<int>> surgeonNumberTimeBlocks,
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