namespace Belien2007.A.E.O.Factories.Parameters.Stochastic.SurgeonStateProbabilities
{
    using System;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Classes.Parameters.Stochastic.SurgeonStateProbabilities;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Stochastic.SurgeonStateProbabilities;
    using Belien2007.A.E.O.Interfaces.Parameters.Stochastic.SurgeonStateProbabilities;
    using Belien2007.A.E.O.InterfacesFactories.Parameters.Stochastic.SurgeonStateProbabilities;

    internal sealed class hFactory : IhFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public hFactory()
        {
        }

        public Ih Create(
            RedBlackTree<IsIndexElement, RedBlackTree<IkIndexElement, IhParameterElement>> value)
        {
            Ih parameter = null;

            try
            {
                parameter = new h(
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