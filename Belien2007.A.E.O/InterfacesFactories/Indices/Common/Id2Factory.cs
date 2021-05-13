namespace Belien2007.A.E.O.InterfacesFactories.Indices.Common
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;

    using Belien2007.A.E.O.Interfaces.Indices.Common;

    public interface Id2Factory
    {
        Id2 Create(
           ImmutableList<Id2IndexElement> value);
    }
}