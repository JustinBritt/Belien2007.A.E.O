namespace Belien2007.A.E.O.InterfacesFactories.Results.Common.DaySurgeonNumberBlockAssignments
{
    using System.Collections.Immutable;

    using Belien2007.A.E.O.Interfaces.ResultElements.Common.DaySurgeonNumberBlockAssignments;
    using Belien2007.A.E.O.Interfaces.Results.Common.DaySurgeonNumberBlockAssignments;

    public interface IxFactory
    {
        Ix Create(
            ImmutableList<IxResultElement> value);
    }
}