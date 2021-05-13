namespace Belien2007.A.E.O.InterfacesFactories.ConstraintElements.Common
{
    using Belien2007.A.E.O.Interfaces.ConstraintElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.ActivePeriods;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonNumberTimeBlocks;
    using Belien2007.A.E.O.Interfaces.Variables.Common;

    public interface IConstraints22_37_316_43_ConstraintElement_Factory
    {
        IConstraints22_37_316_43_ConstraintElement Create(
            IsIndexElement sIndexElement,
            Ii i,
            IA A,
            Ir r,
            Ix x);
    }
}