namespace Belien2007.A.E.O.Classes.Indices.Common
{
    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    
    internal sealed class d2 : Id2
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d2(
            RedBlackTree<INullableValue<int>, Id2IndexElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<INullableValue<int>, Id2IndexElement> Value { get; }
    }
}