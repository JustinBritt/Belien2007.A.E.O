﻿namespace Belien2007.A.E.O.Factories.Parameters.Common.SurgeonLengthOfStayMaximums
{
    using System;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Classes.Parameters.Common.SurgeonLengthOfStayMaximums;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Common.SurgeonLengthOfStayMaximums;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.SurgeonLengthOfStayMaximums;
    using Belien2007.A.E.O.InterfacesFactories.Parameters.Common.SurgeonLengthOfStayMaximums;

    internal sealed class mFactory : ImFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public mFactory()
        {
        }

        public Im Create(
            RedBlackTree<IsIndexElement, ImParameterElement> value)
        {
            Im parameter = null;

            try
            {
                parameter = new m(
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