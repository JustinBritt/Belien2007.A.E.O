namespace Belien2007.A.E.O.Classes.Comparers
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.Comparers;

    internal sealed class FhirDateTimeComparer : IFhirDateTimeComparer
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public FhirDateTimeComparer()
        {
        }

        public int Compare(
            FhirDateTime x,
            FhirDateTime y)
        {
            return x.ToDateTimeOffset(TimeSpan.Zero).UtcDateTime
                .CompareTo(
                y.ToDateTimeOffset(TimeSpan.Zero).UtcDateTime);
        }
    }
}