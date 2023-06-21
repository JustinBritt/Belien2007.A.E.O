namespace Belien2007.A.E.O.Classes.Indices.Common
{   
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Common;

    internal sealed class i : Ii
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public i(
            RedBlackTree<FhirDateTime, IiIndexElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<FhirDateTime, IiIndexElement> Value { get; }

        public IiIndexElement GetElementAt(
            int value)
        {
            return this.Value.Values
                .Where(x => x.Key == value)
                .SingleOrDefault();
        }

        public IiIndexElement GetElementAt(
            FhirDateTime value)
        {
            return this.Value[value];
        }

        public int Getl()
        {
            return this.Value.Values
                .Select(x => x.Key)
                .Max();
        }
    }
}