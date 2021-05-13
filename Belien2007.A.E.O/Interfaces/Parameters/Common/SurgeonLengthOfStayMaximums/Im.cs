namespace Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonLengthOfStayMaximums
{
    using System.Collections.Immutable;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.SurgeonLengthOfStayMaximums;

    public interface Im
    {
        ImmutableList<ImParameterElement> Value { get; }

        int GetElementAtAsint(
            IsIndexElement sIndexElement);
    }
}