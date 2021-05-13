namespace Belien2007.A.E.O.InterfacesFactories.Constraints.MIP2
{
    using System.Collections.Immutable;

    using Belien2007.A.E.O.Interfaces.ConstraintElements.MIP2;
    using Belien2007.A.E.O.Interfaces.Constraints.MIP2;

    public interface IConstraints319Factory
    {
        IConstraints319 Create(
            ImmutableList<IConstraints319ConstraintElement> value);
    }
}