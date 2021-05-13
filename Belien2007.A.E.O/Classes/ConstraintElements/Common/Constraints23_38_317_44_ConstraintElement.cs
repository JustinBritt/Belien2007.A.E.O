namespace Belien2007.A.E.O.Classes.ConstraintElements.Common
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Belien2007.A.E.O.Interfaces.ConstraintElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.DayNumberAvailableTimeBlocks;
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.Interfaces.Variables.Common;

    internal sealed class Constraints23_38_317_44_ConstraintElement : IConstraints23_38_317_44_ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints23_38_317_44_ConstraintElement(
            IiIndexElement iIndexElement,
            Is s,
            Ib b,
            Ix x)
        {
            Expression LHS = Expression.Sum(
                s.Value
                .Select(
                    z => x.Value[iIndexElement, z]));

            int RHS = b.GetElementAtAsint(
                iIndexElement);

            this.Value = LHS <= RHS;
        }

        public Constraint Value { get; }
    }
}