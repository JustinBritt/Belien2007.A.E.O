namespace Belien2007.A.E.O.InterfacesFactories.Results.Common.OverallWallTime
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Belien2007.A.E.O.Interfaces.Results.Common.OverallWallTime;

    public interface IOverallWallTimeFactory
    {
        IOverallWallTime Create(
            TimeSpan value);
    }
}