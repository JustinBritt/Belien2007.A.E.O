﻿namespace Belien2007.A.E.O.InterfacesFactories.ConstraintElements.MIP2
{
    using Belien2007.A.E.O.Interfaces.ConstraintElements.MIP2;
    using Belien2007.A.E.O.Interfaces.CrossJoins.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.ActivePeriods;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonDayLengthOfStayProbabilities;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonLengthOfStayMaximums;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonMaximumNumberPatients;
    using Belien2007.A.E.O.Interfaces.Variables.Common;

    public interface IConstraints318ConstraintElementFactory
    {
        IConstraints318ConstraintElement Create(
            IiIndexElement iIndexElement,
            Id d,
            Ii i,
            Ij j,
            Is s,
            Isj sj,
            IA A,
            Im m,
            ICommonn n,
            Ip p,
            Ix x,
            Iμ μ);
    }
}