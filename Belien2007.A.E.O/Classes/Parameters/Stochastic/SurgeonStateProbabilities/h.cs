namespace Belien2007.A.E.O.Classes.Parameters.Stochastic.SurgeonStateProbabilities
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Stochastic.SurgeonStateProbabilities;
    using Belien2007.A.E.O.Interfaces.Parameters.Stochastic.SurgeonStateProbabilities;

    internal sealed class h : Ih
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public h(
            ImmutableList<IhParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IhParameterElement> Value { get; }

        public decimal GetElementAtAsdecimal(
            IsIndexElement sIndexElement,
            IkIndexElement kIndexElement)
        {
            return this.Value
                .Where(x => x.sIndexElement == sIndexElement && x.kIndexElement == kIndexElement)
                .Select(x => x.Value.Value.Value)
                .SingleOrDefault();
        }
    }
}