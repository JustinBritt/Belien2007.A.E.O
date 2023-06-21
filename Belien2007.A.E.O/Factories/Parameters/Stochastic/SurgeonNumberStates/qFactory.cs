namespace Belien2007.A.E.O.Factories.Parameters.Stochastic.SurgeonNumberStates
{
    using System;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Classes.Parameters.Stochastic.SurgeonNumberStates;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Stochastic.SurgeonNumberStates;
    using Belien2007.A.E.O.Interfaces.Parameters.Stochastic.SurgeonNumberStates;
    using Belien2007.A.E.O.InterfacesFactories.Parameters.Stochastic.SurgeonNumberStates;

    internal sealed class qFactory : IqFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public qFactory()
        {
        }

        public Iq Create(
            RedBlackTree<IsIndexElement, IqParameterElement> value)
        {
            Iq parameter = null;

            try
            {
                parameter = new q(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameter;
        }
    }
}