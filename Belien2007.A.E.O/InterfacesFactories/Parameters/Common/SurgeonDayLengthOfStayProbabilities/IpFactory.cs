namespace Belien2007.A.E.O.InterfacesFactories.Parameters.Common.SurgeonDayLengthOfStayProbabilities
{
    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.SurgeonDayLengthOfStayProbabilities;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonDayLengthOfStayProbabilities;

    public interface IpFactory
    {
        Ip Create(
            RedBlackTree<IsIndexElement, RedBlackTree<IdIndexElement, IpParameterElement>> value);
    }
}