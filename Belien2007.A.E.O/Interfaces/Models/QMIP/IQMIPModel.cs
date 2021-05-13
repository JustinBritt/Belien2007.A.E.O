namespace Belien2007.A.E.O.Interfaces.Models.QMIP
{
    using OPTANO.Modeling.Optimization;

    using Belien2007.A.E.O.Interfaces.CrossJoins.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.ActivePeriods;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.DayBedCapacities;
    using Belien2007.A.E.O.Interfaces.Variables.Common;

    public interface IQMIPModel
    {
        /// <summary>
        /// Gets the Model instance.
        /// </summary>
        Model Model { get; }

        Ii i { get; }

        Is s { get; }

        Isi si { get; }

        IA A { get; }

        Ic c { get; }

        Ix x { get; }

        Iμ μ { get; }

        IVariance Variance { get; }
    }
}