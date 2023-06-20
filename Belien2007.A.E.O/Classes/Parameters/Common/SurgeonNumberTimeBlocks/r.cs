namespace Belien2007.A.E.O.Classes.Parameters.Common.SurgeonNumberTimeBlocks
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.SurgeonNumberTimeBlocks;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonNumberTimeBlocks;

    internal sealed class r : Ir
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public r(
            RedBlackTree<IsIndexElement, IrParameterElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IsIndexElement, IrParameterElement> Value { get; }

        public int GetElementAtAsint(
            IsIndexElement sIndexElement)
        {
            return this.Value[sIndexElement].Value.Value.Value;
        }
    }
}