namespace Belien2007.A.E.O.InterfacesAbstractFactories
{
    using Belien2007.A.E.O.InterfacesFactories.Constraints.Common;
    using Belien2007.A.E.O.InterfacesFactories.Constraints.MIP2;
    using Belien2007.A.E.O.InterfacesFactories.Constraints.QMIP;
    using Belien2007.A.E.O.InterfacesFactories.Constraints.SMIP2;

    public interface IConstraintsAbstractFactory
    {
        IConstraints22_37_316_43_Factory Create_Constraints22_37_316_43_Factory();

        IConstraints23_38_317_44_Factory Create_Constraints23_38_317_44_Factory();

        IConstraints318Factory Create_Constraints318_Factory();

        IConstraints319Factory Create_Constraints319_Factory();

        IConstraints320Factory Create_Constraints320_Factory();

        IConstraints45Factory Create_Constraints45_Factory();

        IConstraintsμFactory Create_Constraintsμ_Factory();

        IQMIPConstraintsVarianceFactory Create_QMIP_ConstraintsVariance_Factory();

        ISMIP2ConstraintsVarianceFactory Create_SMIP2_ConstraintsVariance_Factory();
    }
}