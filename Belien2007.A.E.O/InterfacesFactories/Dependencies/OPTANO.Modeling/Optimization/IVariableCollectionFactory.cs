namespace Belien2007.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using global::OPTANO.Modeling.Optimization;
    using global::OPTANO.Modeling.Optimization.Enums;

    public interface IVariableCollectionFactory
    {
        VariableCollection<T1> Create<T1>(
            IEnumerable<T1> indexSet1,
            Func<T1, double> lowerBoundGenerator,
            Model model,
            Func<T1, double> upperBoundGenerator,
            Func<T1, VariableType> variableTypeGenerator);

        VariableCollection<T1, T2> Create<T1, T2>(
            IEnumerable<T1> indexSet1,
            IEnumerable<T2> indexSet2,
            Func<T1, T2, double> lowerBoundGenerator,
            Model model,
            Func<T1, T2, double> upperBoundGenerator,
            Func<T1, T2, VariableType> variableTypeGenerator);

        VariableCollection<T1, T2, T3> Create<T1, T2, T3>(
            IEnumerable<T1> indexSet1,
            IEnumerable<T2> indexSet2,
            IEnumerable<T3> indexSet3,
            Func<T1, T2, T3, double> lowerBoundGenerator,
            Model model,
            Func<T1, T2, T3, double> upperBoundGenerator,
            Func<T1, T2, T3, VariableType> variableTypeGenerator);

        VariableCollection<T1, T2, T3, T4> Create<T1, T2, T3, T4>(
            IEnumerable<T1> indexSet1,
            IEnumerable<T2> indexSet2,
            IEnumerable<T3> indexSet3,
            IEnumerable<T4> indexSet4,
            Func<T1, T2, T3, T4, double> lowerBoundGenerator,
            Model model,
            Func<T1, T2, T3, T4, double> upperBoundGenerator,
            Func<T1, T2, T3, T4, VariableType> variableTypeGenerator);

        VariableCollection<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(
            IEnumerable<T1> indexSet1,
            IEnumerable<T2> indexSet2,
            IEnumerable<T3> indexSet3,
            IEnumerable<T4> indexSet4,
            IEnumerable<T5> indexSet5,
            Func<T1, T2, T3, T4, T5, double> lowerBoundGenerator,
            Model model,
            Func<T1, T2, T3, T4, T5, double> upperBoundGenerator,
            Func<T1, T2, T3, T4, T5, VariableType> variableTypeGenerator);
    }
}