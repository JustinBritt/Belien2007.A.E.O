namespace Belien2007.A.E.O.Classes.Parameters.Common.ActivePeriods
{
    using System.Linq;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.ActivePeriods;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.ActivePeriods;

    internal sealed class A : IA
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public A(
            RedBlackTree<IiIndexElement, IAParameterElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IiIndexElement, IAParameterElement> Value { get; }

        public int GetElementAtAsint(
            IiIndexElement iIndexElement)
        {
            return this.Value[iIndexElement].Value.Value.Value ? 1 : 0;
        }

        public int GetElementAtAsint(
            IjIndexElement jIndexElement)
        {
            return this.Value.Values
                .Where(x => x.iIndexElement.Key == jIndexElement.Key)
                .Select(x => x.Value.Value.Value ? 1 : 0)
                .SingleOrDefault();
        }
    }
}