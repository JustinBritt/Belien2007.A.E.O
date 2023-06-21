namespace Belien2007.A.E.O.Factories.Contexts.MIP2
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

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
            RedBlackTree<INullableValue<int>, FhirDateTime> planningHorizon,
            Bundle surgeons,
            RedBlackTree<FhirDateTime, INullableValue<bool>> activePeriods,
            RedBlackTree<FhirDateTime, INullableValue<int>> dayNumberTimeBlocks,
            RedBlackTree<FhirDateTime, INullableValue<int>> dayBedCapacities,
            RedBlackTree<Organization, INullableValue<int>> surgeonLengthOfStayMaximums,
            RedBlackTree<Organization, INullableValue<int>> surgeonMaximumNumberPatients,
            RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> surgeonDayLengthOfStayProbabilities,
            RedBlackTree<Organization, INullableValue<int>> surgeonNumberTimeBlocks,
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