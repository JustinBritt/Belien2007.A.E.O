namespace Belien2007.A.E.O.Interfaces.Variables.Common
{
    using OPTANO.Modeling.Optimization;

    using Belien2007.A.E.O.Interfaces.CrossJoins.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.Parameters.Common.ActivePeriods;
    using Belien2007.A.E.O.InterfacesFactories.ResultElements.Common.DaySurgeonNumberBlockAssignments;
    using Belien2007.A.E.O.InterfacesFactories.Results.Common.DaySurgeonNumberBlockAssignments;

    public interface Ix
    {
        VariableCollection<IiIndexElement, IsIndexElement> Value { get; }

        int GetElementAt(
            IiIndexElement iIndexElement,
            IsIndexElement sIndexElement);

        Interfaces.Results.Common.DaySurgeonNumberBlockAssignments.Ix GetElementsAt(
            IxResultElementFactory xResultElementFactory,
            IxFactory xFactory,
            Isi si,
            IA A);
    }
}