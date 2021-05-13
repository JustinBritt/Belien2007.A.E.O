namespace Belien2007.A.E.O.Classes.Results.Common.NumberOfExploredNodes
{
    using log4net;

    using Belien2007.A.E.O.Interfaces.Results.Common.NumberOfExploredNodes;

    internal sealed class NumberOfExploredNodes : INumberOfExploredNodes
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public NumberOfExploredNodes(
            long value)
        {
            this.Value = value;
        }

        public long Value { get; }

        public long GetValueForOutputContext()
        {
            return this.Value;
        }
    }
}