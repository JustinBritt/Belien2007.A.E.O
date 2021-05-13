namespace Belien2007.A.E.O.Factories.Parameters.Common.SurgeonMaximumNumberPatients
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Belien2007.A.E.O.Classes.Parameters.Common.SurgeonMaximumNumberPatients;
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
            ImmutableList<ICommonnParameterElement> value)
        {
            ICommonn parameter = null;

            try
            {
                parameter = new Commonn(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return parameter;
        }
    }
}