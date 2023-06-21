namespace Belien2007.A.E.O.Classes.ConstraintElements.Common
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Belien2007.A.E.O.Interfaces.ConstraintElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.ActivePeriods;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonNumberTimeBlocks;
    using Belien2007.A.E.O.Interfaces.Variables.Common;

    internal sealed class Constraints22_37_316_43_ConstraintElement : IConstraints22_37_316_43_ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints22_37_316_43_ConstraintElement(
            IsIndexElement sIndexElement,
            Ii i,
            IA A,
            Ir r,
            Ix x)
        {
            Expression LHS = Expression.Sum(
                i.Value.Values
                .Where(y => A.GetElementAtAsint(y) == 1)
                .Select(
                    z => x.Value[z, sIndexElement]));

            int RHS = r.GetElementAtAsint(
                sIndexElement);

            this.Value = LHS == RHS;
        }

        public Constraint Value { get; }
    }
}