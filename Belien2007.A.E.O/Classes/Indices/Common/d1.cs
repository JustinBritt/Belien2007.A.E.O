namespace Belien2007.A.E.O.Classes.Indices.Common
{
    using System.Collections.Immutable;

    using log4net;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Common;

    internal sealed class d1 : Id1
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d1(
            ImmutableList<Id1IndexElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<Id1IndexElement> Value { get; }
    }
}