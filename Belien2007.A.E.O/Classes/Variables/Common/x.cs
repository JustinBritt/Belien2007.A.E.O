namespace Belien2007.A.E.O.Classes.Variables.Common
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Belien2007.A.E.O.Interfaces.CrossJoins.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.ActivePeriods;
    using Belien2007.A.E.O.Interfaces.Variables.Common;
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Common.DaySurgeonNumberBlockAssignments;
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.DaySurgeonNumberBlockAssignments;

    internal sealed class x : Ix
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public x(
            VariableCollection<IiIndexElement, IsIndexElement> value)
        {
            this.Value = value;
        }

        public VariableCollection<IiIndexElement, IsIndexElement> Value { get; }

        public int GetElementAt(
            IiIndexElement iIndexElement,
            IsIndexElement sIndexElement)
        {
            int value = 0;

            int rounded = (int)Math.Round(
                this.Value[iIndexElement, sIndexElement].Value,
                0,
                MidpointRounding.AwayFromZero);

            if (this.Value[iIndexElement, sIndexElement].Value.IsAlmost(rounded))
            {
                value = rounded;
            }

            return value;
        }

        public Interfaces.Results.Common.DaySurgeonNumberBlockAssignments.Ix GetElementsAt(
            IxResultElementFactory xResultElementFactory,
            IxFactory xFactory,
            Isi si,
            IA A)
        {
            return xFactory.Create(
                si.Value
                .Where(w => A.GetElementAtAsint(w.iIndexElement) == 1)
                .Select(
                    w => xResultElementFactory.Create(
                        w.iIndexElement,
                        w.sIndexElement,
                        this.GetElementAt(
                            w.iIndexElement,
                            w.sIndexElement)))
                .ToImmutableList());
        }
    }
}