﻿namespace Belien2007.A.E.O.Factories.ConstraintElements.MIP2
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Classes.ConstraintElements.MIP2;
    using Belien2007.A.E.O.Interfaces.ConstraintElements.MIP2;
    using Belien2007.A.E.O.Interfaces.CrossJoins.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.ActivePeriods;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonDayLengthOfStayProbabilities;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonLengthOfStayMaximums;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonMaximumNumberPatients;
    using Belien2007.A.E.O.Interfaces.Variables.Common;
    using Belien2007.A.E.O.InterfacesFactories.ConstraintElements.MIP2;

    internal sealed class Constraints319ConstraintElementFactory : IConstraints319ConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints319ConstraintElementFactory()
        {
        }

        public IConstraints319ConstraintElement Create(
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
            IVariance Variance)
        {
            IConstraints319ConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints319ConstraintElement(
                    iIndexElement,
                    d,
                    i,
                    j,
                    s,
                    sj,
                    A,
                    m,
                    n,
                    p,
                    x,
                    Variance);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return constraintElement;
        }
    }
}