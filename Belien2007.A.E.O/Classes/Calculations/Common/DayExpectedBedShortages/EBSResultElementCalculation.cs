namespace Belien2007.A.E.O.Classes.Calculations.Common.DayExpectedBedShortages
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Interfaces.Calculations.Common.DayExpectedBedShortages;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.DayBedCapacities;
    using Belien2007.A.E.O.Interfaces.ResultElements.Common.DayExpectedBedShortages;
    using Belien2007.A.E.O.Interfaces.Results.Common.DayBedOccupancyMeans;
    using Belien2007.A.E.O.Interfaces.Results.Common.DayBedOccupancyVariances;
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Common.DayExpectedBedShortages;

    internal sealed class EBSResultElementCalculation : IEBSResultElementCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public EBSResultElementCalculation()
        {
        }

        public IEBSResultElement Calculate(
            IEBSResultElementFactory EBSResultElementFactory,
            IiIndexElement iIndexElement,
            Ic c,
            Iμ μ,
            IVariance Variance)
        {
            int c_i = c.GetElementAtAsint(
                iIndexElement);

            double ExpectedValue_i = (double)μ.GetElementAtAsdecimal(
                iIndexElement);

            double Variance_i = (double)Variance.GetElementAtAsdecimal(
                iIndexElement);

            double lowerBound = c_i + 0.5;

            double upperBound = double.PositiveInfinity;

            double value =
                0.5
                *
                (c_i - ExpectedValue_i)
                *
                (MathNet.Numerics.SpecialFunctions.Erf(
                    (lowerBound - ExpectedValue_i)
                    *
                    Math.Pow(Math.Sqrt(2 * Variance_i), -1))
                -
                MathNet.Numerics.SpecialFunctions.Erf(
                    (upperBound - ExpectedValue_i)
                    *
                    Math.Pow(Math.Sqrt(2 * Variance_i), -1)))
                +
                Math.Sqrt(Variance_i)
                *
                Math.Pow(Math.Sqrt(2 * Math.PI), -1)
                *
                (Math.Exp(
                    -Math.Pow(lowerBound - ExpectedValue_i, 2)
                    *
                    Math.Pow(2 * Variance_i, -1))
                -
                Math.Exp(
                    -Math.Pow(upperBound - ExpectedValue_i, 2)
                    *
                    Math.Pow(2 * Variance_i, -1)));

            return EBSResultElementFactory.Create(
                iIndexElement,
                (decimal)value);
        }
    }
}