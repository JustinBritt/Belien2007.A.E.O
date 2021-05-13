namespace Belien2007.A.E.O.Interfaces.Variables.Common
{
    using OPTANO.Modeling.Optimization;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Common.DayBedOccupancyVariances;
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.DayBedOccupancyVariances;

    public interface IVariance
    {
        VariableCollection<IiIndexElement> Value { get; }

        decimal GetElementAt(
            IiIndexElement iIndexElement);

        Interfaces.Results.Common.DayBedOccupancyVariances.IVariance GetElementsAt(
            IVarianceResultElementFactory VarianceResultElementFactory,
            IVarianceFactory VarianceFactory,
            Ii i);
    }
}