namespace Belien2007.A.E.O.InterfacesFactories.Variables.Common
{
    using OPTANO.Modeling.Optimization;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Variables.Common;

    public interface IxFactory
    {
        Ix Create(
            VariableCollection<IiIndexElement, IsIndexElement> value);
    }
}