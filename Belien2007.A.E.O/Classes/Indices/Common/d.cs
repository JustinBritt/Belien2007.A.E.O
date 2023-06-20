namespace Belien2007.A.E.O.Classes.Indices.Common
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;

    internal sealed class d : Belien2007.A.E.O.Interfaces.Indices.Common.Id
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d(
            RedBlackTree<INullableValue<int>, IdIndexElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<INullableValue<int>, IdIndexElement> Value { get; }

        public IdIndexElement GetElementAt(
            int value)
        {
            return this.Value.Values
                .Where(x => x.Value.Value.Value == value)
                .SingleOrDefault();
        }

        public IdIndexElement GetElementAt(
            INullableValue<int> value)
        {
            return this.Value[value];
        }

        public ImmutableList<IdIndexElement> GetNthElementsAt(
            int startKey,
            int endKey,
            int N)
        {
            ImmutableList<IdIndexElement>.Builder builder = ImmutableList.CreateBuilder<IdIndexElement>();

            for (int i = startKey; i <= endKey; i = i + N)
            {
                builder.Add(
                    this.GetElementAt(
                        i));
            }

            return builder.ToImmutableList();
        }
    }
}