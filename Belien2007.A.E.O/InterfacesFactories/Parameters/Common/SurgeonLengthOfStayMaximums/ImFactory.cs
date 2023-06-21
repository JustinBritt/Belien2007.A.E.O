namespace Belien2007.A.E.O.InterfacesFactories.Parameters.Common.SurgeonLengthOfStayMaximums
{
    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.SurgeonLengthOfStayMaximums;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonLengthOfStayMaximums;

    public interface ImFactory
    {
        Im Create(
            RedBlackTree<IsIndexElement, ImParameterElement> value);
    }
}