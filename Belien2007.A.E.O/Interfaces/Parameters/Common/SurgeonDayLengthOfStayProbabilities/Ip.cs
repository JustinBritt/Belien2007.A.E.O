namespace Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonDayLengthOfStayProbabilities
{
    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.SurgeonDayLengthOfStayProbabilities;

    public interface Ip
    {
        RedBlackTree<IsIndexElement, RedBlackTree<IdIndexElement, IpParameterElement>> Value { get; }

        decimal GetElementAtAsdecimal(
            IsIndexElement sIndexElement,
            IdIndexElement dIndexElement);
    }
}