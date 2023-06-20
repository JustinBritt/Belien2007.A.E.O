namespace Belien2007.A.E.O.Classes.Indices.Stochastic
{
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;
    using Belien2007.A.E.O.Interfaces.Indices.Stochastic;

    internal sealed class k : Ik
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public k(
            RedBlackTree<INullableValue<int>, IkIndexElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<INullableValue<int>, IkIndexElement> Value { get; }

        public IkIndexElement GetElementAt(
            int value)
        {
            return this.Value.Values
                .Where(x => x.Value.Value.Value == value)
                .SingleOrDefault();
        }

        public IkIndexElement GetElementAt(
            INullableValue<int> value)
        {
            return this.Value[value];
        }
    }
}