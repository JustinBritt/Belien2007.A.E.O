namespace Belien2007.A.E.O.Classes.Indices.Common
{
    using System.Collections.Immutable;

    using log4net;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Common;

    internal sealed class d2 : Id2
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d2(
            ImmutableList<Id2IndexElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<Id2IndexElement> Value { get; }
    }
}