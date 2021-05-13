namespace Belien2007.A.E.O.InterfacesFactories.Results.Common.SurgeonNumberAssignedDays
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Belien2007.A.E.O.Interfaces.ResultElements.Common.SurgeonNumberAssignedDays;
    using Belien2007.A.E.O.Interfaces.Results.Common.SurgeonNumberAssignedDays;

    public interface ISurgeonNumberAssignedDaysFactory
    {
        ISurgeonNumberAssignedDays Create(
            ImmutableList<ISurgeonNumberAssignedDaysResultElement> value);
    }
}