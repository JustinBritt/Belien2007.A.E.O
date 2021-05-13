namespace Belien2007.A.E.O.Classes.Parameters.Common.SurgeonDayLengthOfStayProbabilities
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.SurgeonDayLengthOfStayProbabilities;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonDayLengthOfStayProbabilities;

    internal sealed class p : Ip
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public p(
            ImmutableList<IpParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IpParameterElement> Value { get; }

        public decimal GetElementAtAsdecimal(
            IsIndexElement sIndexElement,
            IdIndexElement dIndexElement)
        {
            return this.Value
                .Where(x => x.sIndexElement == sIndexElement && x.dIndexElement == dIndexElement)
                .Select(x => x.Value.Value.Value)
                .SingleOrDefault();
        }
    }
}