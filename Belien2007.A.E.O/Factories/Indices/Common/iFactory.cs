namespace Belien2007.A.E.O.Factories.Indices.Common
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Classes.Indices.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.InterfacesFactories.Indices.Common;
    
    internal sealed class iFactory : IiFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public iFactory()
        {
        }

        public Ii Create(
            RedBlackTree<FhirDateTime, IiIndexElement> value)
        {
            Ii index = null;

            try
            {
                index = new i(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return index;
        }
    }
}