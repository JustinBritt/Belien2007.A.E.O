namespace Belien2007.A.E.O.InterfacesFactories.Results.Common.DayBedOccupancyMeans
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Belien2007.A.E.O.Interfaces.ResultElements.Common.DayBedOccupancyMeans;

    using Belien2007.A.E.O.Interfaces.Results.Common.DayBedOccupancyMeans;

    public interface IμFactory
    {
        Iμ Create(
            ImmutableList<IμResultElement> value);
    }
}