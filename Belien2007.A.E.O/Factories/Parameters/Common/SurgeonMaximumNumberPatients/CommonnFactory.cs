namespace Belien2007.A.E.O.Factories.Parameters.Common.SurgeonMaximumNumberPatients
{
    using System;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Classes.Parameters.Common.SurgeonMaximumNumberPatients;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.SurgeonMaximumNumberPatients;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonMaximumNumberPatients;
    using Belien2007.A.E.O.InterfacesFactories.Parameters.Common.SurgeonMaximumNumberPatients;

    internal sealed class CommonnFactory : ICommonnFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CommonnFactory()
        {
        }

        public ICommonn Create(
            RedBlackTree<IsIndexElement, ICommonnParameterElement> value)
        {
            ICommonn parameter = null;

            try
            {
                parameter = new Commonn(
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