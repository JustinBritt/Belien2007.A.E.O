namespace Belien2007.A.E.O.Classes.Parameters.Common.SurgeonMaximumNumberPatients
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.SurgeonMaximumNumberPatients;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonMaximumNumberPatients;

    internal sealed class Commonn : ICommonn
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Commonn(
            RedBlackTree<IsIndexElement, ICommonnParameterElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IsIndexElement, ICommonnParameterElement> Value { get; }

        public int GetElementAtAsint(
            IsIndexElement sIndexElement)
        {
            return this.Value[sIndexElement].Value.Value.Value;
        }
    }
}