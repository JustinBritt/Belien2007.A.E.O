namespace Belien2007.A.E.O.InterfacesVisitors.Contexts.SMIP2
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;
    using Belien2007.A.E.O.Interfaces.ParameterElements.Stochastic.SurgeonStateMaximumNumberPatients;

    public interface ISurgeonStateMaximumNumberPatientsOuterVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : Organization
        where TValue : RedBlackTree<INullableValue<int>, INullableValue<int>>
    {
        RedBlackTree<IsIndexElement, RedBlackTree<IkIndexElement, IStochasticnParameterElement>> RedBlackTree { get; }
    }
}