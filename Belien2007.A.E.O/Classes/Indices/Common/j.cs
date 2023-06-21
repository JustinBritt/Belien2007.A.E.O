namespace Belien2007.A.E.O.Classes.Indices.Common
{
    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Common;

    internal sealed class j : Ij
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public j(
            RedBlackTree<FhirDateTime, IjIndexElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<FhirDateTime, IjIndexElement> Value { get; }

        public IjIndexElement GetElementAt(
            FhirDateTime value)
        {
            return this.Value[value];
        }
    }
}