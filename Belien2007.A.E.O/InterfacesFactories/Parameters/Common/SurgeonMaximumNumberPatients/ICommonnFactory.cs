namespace Belien2007.A.E.O.InterfacesFactories.Parameters.Common.SurgeonMaximumNumberPatients
{
    using System.Collections.Immutable;

    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.SurgeonMaximumNumberPatients;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonMaximumNumberPatients;

    public interface ICommonnFactory
    {
        ICommonn Create(
            ImmutableList<ICommonnParameterElement> value);
    }
}