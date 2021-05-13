namespace Belien2007.A.E.O.Classes.Calculations.Common.TotalExpectedBedShortage
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Belien2007.A.E.O.Interfaces.Calculations.Common.TotalExpectedBedShortage;
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.Interfaces.Results.Common.DayExpectedBedShortages;
    using Belien2007.A.E.O.Interfaces.Results.Common.TotalExpectedBedShortage;
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.TotalExpectedBedShortage;

    internal sealed class TEBSCalculation : ITEBSCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TEBSCalculation()
        {
        }

        public ITEBS Calculate(
            ITEBSFactory TEBSFactory,
            Ii i,
            IEBS EBS)
        {
            return TEBSFactory.Create(
                i.Value
                .Select(w => EBS.GetElementAtAsdecimal(
                    w))
                .ToImmutableList()
                .Sum());
        }
    }
}