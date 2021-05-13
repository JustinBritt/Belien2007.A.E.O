namespace Belien2007.A.E.O.Classes.Results.Common.OverallWallTime
{
    using System;

    using log4net;

    using Belien2007.A.E.O.Interfaces.Results.Common.OverallWallTime;

    internal sealed class OverallWallTime : IOverallWallTime
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public OverallWallTime(
            TimeSpan value)
        {
            this.Value = value;
        }

        public TimeSpan Value { get; }

        public TimeSpan GetValueForOutputContext()
        {
            return this.Value;
        }
    }
}