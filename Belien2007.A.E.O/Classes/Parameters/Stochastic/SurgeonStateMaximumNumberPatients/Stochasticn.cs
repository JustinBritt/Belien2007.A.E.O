namespace Belien2007.A.E.O.Classes.Parameters.Stochastic.SurgeonStateMaximumNumberPatients
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Stochastic.SurgeonStateMaximumNumberPatients;
    using Belien2007.A.E.O.Interfaces.Parameters.Stochastic.SurgeonStateMaximumNumberPatients;

    internal sealed class Stochasticn : IStochasticn
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Stochasticn(
            ImmutableList<IStochasticnParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IStochasticnParameterElement> Value { get; }

        public int GetElementAtAsint(
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