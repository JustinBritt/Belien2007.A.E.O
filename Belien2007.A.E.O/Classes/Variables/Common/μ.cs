namespace Belien2007.A.E.O.Classes.Variables.Common
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.Interfaces.Variables.Common;
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Common.DayBedOccupancyMeans;
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.DayBedOccupancyMeans;

    internal sealed class μ : Iμ
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public μ(
            VariableCollection<IiIndexElement> value)
        {
            this.Value = value;
        }

        public VariableCollection<IiIndexElement> Value { get; }

        public decimal GetElementAt(
            IiIndexElement iIndexElement)
        {
            return (decimal)this.Value[iIndexElement].Value;
        }

        public Interfaces.Results.Common.DayBedOccupancyMeans.Iμ GetElementsAt(
            IμResultElementFactory μResultElementFactory,
            IμFactory μFactory,
            Ii i)
        {
            return μFactory.Create(
                i.Value.Values
                .Select(
                    w => μResultElementFactory.Create(
                        w,
                        this.GetElementAt(
                            w)))
                .ToImmutableList());
        }
    }
}