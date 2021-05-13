namespace Belien2007.A.E.O.Interfaces.Models.SMIP2
{
    using OPTANO.Modeling.Optimization;

    using Belien2007.A.E.O.Interfaces.CrossJoins.Common;
    using Belien2007.A.E.O.Interfaces.CrossJoins.Stochastic;
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Stochastic;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.ActivePeriods;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.DayBedCapacities;
    using Belien2007.A.E.O.Interfaces.Parameters.Stochastic.SurgeonStateMaximumNumberPatients;
    using Belien2007.A.E.O.Interfaces.Variables.Common;
    using Belien2007.A.E.O.Interfaces.Variables.MIP2;

    public interface ISMIP2Model
    {
        /// <summary>
        /// Gets the Model instance.
        /// </summary>
        Model Model { get; }

        Ii i { get; }

        Ik k { get; }

        Is s { get; }

        Isi si { get; }

        Isk sk { get; }

        IA A { get; }

        Ic c { get; }

        IStochasticn n { get; }

        Ix x { get; }

        Iγ γ { get; }

        Iμ μ { get; }

        IVariance Variance { get; }
    }
}