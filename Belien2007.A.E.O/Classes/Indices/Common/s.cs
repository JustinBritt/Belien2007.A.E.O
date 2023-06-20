namespace Belien2007.A.E.O.Classes.Indices.Common
{
    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Common;

    internal sealed class s : Is
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public s(
            RedBlackTree<Organization, IsIndexElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<Organization, IsIndexElement> Value { get; }

        public IsIndexElement GetElementAt(
            Organization value)
        {
            return this.Value[value];
        }
    }
}