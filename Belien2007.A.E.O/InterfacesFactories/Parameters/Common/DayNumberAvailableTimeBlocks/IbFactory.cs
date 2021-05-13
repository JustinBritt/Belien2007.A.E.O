namespace Belien2007.A.E.O.InterfacesFactories.Parameters.Common.DayNumberAvailableTimeBlocks
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.DayNumberAvailableTimeBlocks;

    using Belien2007.A.E.O.Interfaces.Parameters.Common.DayNumberAvailableTimeBlocks;

    public interface IbFactory
    {
        Ib Create(
            ImmutableList<IbParameterElement> value);
    }
}