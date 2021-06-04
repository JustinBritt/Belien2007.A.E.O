namespace Belien2007.A.E.O.Factories.Parameters.Common.SurgeonDayLengthOfStayProbabilities
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Belien2007.A.E.O.Classes.Parameters.Common.SurgeonDayLengthOfStayProbabilities;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.SurgeonDayLengthOfStayProbabilities;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonDayLengthOfStayProbabilities;
    using Belien2007.A.E.O.InterfacesFactories.Parameters.Common.SurgeonDayLengthOfStayProbabilities;

    internal sealed class pFactory : IpFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public pFactory()
        {
        }

        public Ip Create(
            ImmutableList<IpParameterElement> value)
        {
            Ip parameter = null;

            try
            {
                parameter = new p(
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