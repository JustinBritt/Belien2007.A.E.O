namespace Belien2007.A.E.O.Factories.Variables.Common
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Belien2007.A.E.O.Classes.Variables.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Variables.Common;
    using Belien2007.A.E.O.InterfacesFactories.Variables.Common;

    internal sealed class VarianceFactory : IVarianceFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VarianceFactory()
        {
        }

        public IVariance Create(
            VariableCollection<IiIndexElement> value)
        {
            IVariance variable = null;

            try
            {
                variable = new Variance(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return variable;
        }
    }
}