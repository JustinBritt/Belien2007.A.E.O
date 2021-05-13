namespace Belien2007.A.E.O.InterfacesFactories.Variables.MIP2
{
    using OPTANO.Modeling.Optimization;

    using Belien2007.A.E.O.Interfaces.Variables.MIP2;

    public interface IγFactory
    {
        Iγ Create(
            Variable value);
    }
}