﻿namespace Belien2007.A.E.O.Factories.Variables.Common
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Belien2007.A.E.O.Classes.Variables.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Variables.Common;
    using Belien2007.A.E.O.InterfacesFactories.Variables.Common;

    internal sealed class μFactory : IμFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public μFactory()
        {
        }

        public Iμ Create(
            VariableCollection<IiIndexElement> value)
        {
            Iμ variable = null;

            try
            {
                variable = new μ(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return variable;
        }
    }
}