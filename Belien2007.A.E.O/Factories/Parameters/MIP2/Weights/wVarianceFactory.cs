namespace Belien2007.A.E.O.Factories.Parameters.MIP2.Weights
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Belien2007.A.E.O.Classes.Parameters.MIP2.Weights;
    using Belien2007.A.E.O.Interfaces.Parameters.MIP2.Weights;
    using Belien2007.A.E.O.InterfacesFactories.Parameters.MIP2.Weights;

    internal sealed class wVarianceFactory : IwVarianceFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public wVarianceFactory()
        {
        }

        public IwVariance Create(
            INullableValue<decimal> value)
        {
            IwVariance parameter = null;

            try
            {
                parameter = new wVariance(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameter;
        }
    }
}