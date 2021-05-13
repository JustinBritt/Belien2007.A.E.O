namespace Belien2007.A.E.O.InterfacesAbstractFactories
{
    using Belien2007.A.E.O.InterfacesFactories.ConstraintElements.Common;
    using Belien2007.A.E.O.InterfacesFactories.ConstraintElements.MIP2;
    using Belien2007.A.E.O.InterfacesFactories.ConstraintElements.QMIP;
    using Belien2007.A.E.O.InterfacesFactories.ConstraintElements.SMIP2;

    public interface IConstraintElementsAbstractFactory
    {
        IConstraints22_37_316_43_ConstraintElement_Factory Create_Constraints22_37_316_43_ConstraintElement_Factory();

        IConstraints23_38_317_44_ConstraintElement_Factory Create_Constraints23_38_317_44_ConstraintElement_Factory();

        IConstraints318ConstraintElementFactory CreateConstraints318ConstraintElementFactory();

        IConstraints319ConstraintElementFactory CreateConstraints319ConstraintElementFactory();

        IConstraints320ConstraintElementFactory CreateConstraints320ConstraintElementFactory();

        IConstraints45ConstraintElementFactory CreateConstraints45ConstraintElementFactory();

        IConstraintsμConstraintElementFactory CreateConstraintsμConstraintElementFactory();

        IQMIPConstraintsVarianceConstraintElementFactory CreateQMIPConstraintsVarianceConstraintElementFactory();

        ISMIP2ConstraintsVarianceConstraintElementFactory CreateSMIP2ConstraintsVarianceConstraintElementFactory();
    }
}