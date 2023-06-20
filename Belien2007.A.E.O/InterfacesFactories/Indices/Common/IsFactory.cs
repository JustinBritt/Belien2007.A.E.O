namespace Belien2007.A.E.O.InterfacesFactories.Indices.Common
{
    using System.Collections.Immutable;

    using Belien2007.A.E.O.Interfaces.Comparers;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Common;

    public interface IsFactory
    {
        Is Create(
            IOrganizationComparer organizationComparer,
            ImmutableList<IsIndexElement> value);
    }
}