namespace Belien2007.A.E.O.Classes.Variables.MIP2
{
    using log4net;

    using OPTANO.Modeling.Optimization;

    using Belien2007.A.E.O.Interfaces.Variables.MIP2;

    internal sealed class γ : Iγ
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public γ(
            Variable value)
        {
            this.Value = value;
        }

        public Variable Value { get; }
    }
}