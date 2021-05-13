namespace Belien2007.A.E.O.Classes.Indices.Common
{   
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Common;

    internal sealed class i : Ii
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public i(
            ImmutableList<IiIndexElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IiIndexElement> Value { get; }

        public IiIndexElement GetElementAt(
            int value)
        {
            return this.Value
                .Where(x => x.Key == value)
                .SingleOrDefault();
        }

        public IiIndexElement GetElementAt(
            FhirDateTime value)
        {
            return this.Value
                .Where(x => x.Value == value)
                .SingleOrDefault();
        }

        public int Getl()
        {
            return this.Value
                .Select(x => x.Key)
                .Max();
        }
    }
}