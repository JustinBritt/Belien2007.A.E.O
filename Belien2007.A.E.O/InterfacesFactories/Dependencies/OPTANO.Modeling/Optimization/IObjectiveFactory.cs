namespace Belien2007.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using global::OPTANO.Modeling.Optimization;
    using global::OPTANO.Modeling.Optimization.Enums;

    public interface IObjectiveFactory
    {
        Objective Create(
            Expression expression,
            ObjectiveSense objectiveSense);
    }
}