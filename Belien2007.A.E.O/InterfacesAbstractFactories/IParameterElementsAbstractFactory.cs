namespace Belien2007.A.E.O.InterfacesAbstractFactories
{
    using Belien2007.A.E.O.InterfacesFactories.ParameterElements.Common.ActivePeriods;
    using Belien2007.A.E.O.InterfacesFactories.ParameterElements.Common.DayBedCapacities;
    using Belien2007.A.E.O.InterfacesFactories.ParameterElements.Common.DayNumberAvailableTimeBlocks;
    using Belien2007.A.E.O.InterfacesFactories.ParameterElements.Common.SurgeonDayLengthOfStayProbabilities;
    using Belien2007.A.E.O.InterfacesFactories.ParameterElements.Common.SurgeonLengthOfStayMaximums;
    using Belien2007.A.E.O.InterfacesFactories.ParameterElements.Common.SurgeonMaximumNumberPatients;
    using Belien2007.A.E.O.InterfacesFactories.ParameterElements.Common.SurgeonNumberTimeBlocks;
    using Belien2007.A.E.O.InterfacesFactories.ParameterElements.Stochastic.SurgeonNumberStates;
    using Belien2007.A.E.O.InterfacesFactories.ParameterElements.Stochastic.SurgeonStateMaximumNumberPatients;
    using Belien2007.A.E.O.InterfacesFactories.ParameterElements.Stochastic.SurgeonStateProbabilities;

    public interface IParameterElementsAbstractFactory
    {
        IAParameterElementFactory CreateAParameterElementFactory();

        IbParameterElementFactory CreatebParameterElementFactory();

        IcParameterElementFactory CreatecParameterElementFactory();

        ICommonnParameterElementFactory CreateCommonnParameterElementFactory();

        IhParameterElementFactory CreatehParameterElementFactory();

        ImParameterElementFactory CreatemParameterElementFactory();

        IpParameterElementFactory CreatepParameterElementFactory();

        IqParameterElementFactory CreateqParameterElementFactory();

        IrParameterElementFactory CreaterParameterElementFactory();

        IStochasticnParameterElementFactory CreateStochasticnParameterElementFactory();
    }
}