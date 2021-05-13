namespace Belien2007.A.E.O.Factories.Dependencies.OPTANO.Modeling.Optimization
{
    using System;

    using log4net;

    using global::OPTANO.Modeling.Optimization;
    using global::OPTANO.Modeling.Optimization.Enums;

    using Belien2007.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;

    internal sealed class VariableFactory : IVariableFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VariableFactory()
        {
        }

        public Variable Create()
        {
            Variable variable = null;

            try
            {
                variable = new Variable();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return variable;
        }

        public Variable Create(
            double lowerbound,
            VariableType type,
            double upperbound)
        {
            Variable variable = null;

            try
            {
                variable = new Variable(
                    lowerbound: lowerbound,
                    upperbound: upperbound,
                    type: type);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return variable;
        }

        public Variable Create(
            double lowerbound,
            string name,
            VariableType type,
            double upperbound)
        {
            Variable variable = null;

            try
            {
                variable = new Variable(
                    name: name,
                    lowerbound: lowerbound,
                    upperbound: upperbound,
                    type: type);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return variable;
        }
    }
}