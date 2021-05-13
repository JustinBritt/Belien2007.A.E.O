namespace Belien2007.A.E.O.Interfaces.Variables.Common
{
    using OPTANO.Modeling.Optimization;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Common.DayBedOccupancyMeans;
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.DayBedOccupancyMeans;

    public interface Iμ
    {
        VariableCollection<IiIndexElement> Value { get; }

        decimal GetElementAt(
            IiIndexElement iIndexElement);

        Interfaces.Results.Common.DayBedOccupancyMeans.Iμ GetElementsAt(
            IμResultElementFactory μResultElementFactory,
            IμFactory μFactory,
            Ii i);
    }
}