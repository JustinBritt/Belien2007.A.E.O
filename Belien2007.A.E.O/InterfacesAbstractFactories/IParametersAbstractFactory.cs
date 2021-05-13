namespace Belien2007.A.E.O.InterfacesAbstractFactories
{
    using Belien2007.A.E.O.InterfacesFactories.Parameters.Common.ActivePeriods;
    using Belien2007.A.E.O.InterfacesFactories.Parameters.Common.DayBedCapacities;
    using Belien2007.A.E.O.InterfacesFactories.Parameters.Common.DayNumberAvailableTimeBlocks;
    using Belien2007.A.E.O.InterfacesFactories.Parameters.Common.SurgeonDayLengthOfStayProbabilities;
    using Belien2007.A.E.O.InterfacesFactories.Parameters.Common.SurgeonLengthOfStayMaximums;
    using Belien2007.A.E.O.InterfacesFactories.Parameters.Common.SurgeonMaximumNumberPatients;
    using Belien2007.A.E.O.InterfacesFactories.Parameters.Common.SurgeonNumberTimeBlocks;
    using Belien2007.A.E.O.InterfacesFactories.Parameters.MIP2.Weights;
    using Belien2007.A.E.O.InterfacesFactories.Parameters.Stochastic.SurgeonNumberStates;
    using Belien2007.A.E.O.InterfacesFactories.Parameters.Stochastic.SurgeonStateMaximumNumberPatients;
    using Belien2007.A.E.O.InterfacesFactories.Parameters.Stochastic.SurgeonStateProbabilities;

    public interface IParametersAbstractFactory
    {
        IAFactory CreateAFactory();

        IbFactory CreatebFactory();

        IcFactory CreatecFactory();

        ICommonnFactory CreateCommonnFactory();

        IhFactory CreatehFactory();

        ImFactory CreatemFactory();

        IpFactory CreatepFactory();

        IqFactory CreateqFactory();

        IrFactory CreaterFactory();

        IStochasticnFactory CreateStochasticnFactory();

        IwMeanFactory CreatewMeanFactory();

        IwVarianceFactory CreatewVarianceFactory();
    }
}