namespace Belien2007.A.E.O.Classes.Results.Stochastic.SurgeonStateNumberPatients
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Belien2007.A.E.O.Interfaces.IndexElements.Common;
    using Belien2007.A.E.O.Interfaces.IndexElements.Stochastic;
    using Belien2007.A.E.O.Interfaces.Indices.Common;
    using Belien2007.A.E.O.Interfaces.Indices.Stochastic;
    using Belien2007.A.E.O.Interfaces.ResultElements.Stochastic.SurgeonStateNumberPatients;
    using Belien2007.A.E.O.Interfaces.Results.Stochastic.SurgeonStateNumberPatients;
    using Belien2007.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    
    internal sealed class SurgeonStateNumberPatients : ISurgeonStateNumberPatients
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonStateNumberPatients(
            ImmutableList<ISurgeonStateNumberPatientsResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<ISurgeonStateNumberPatientsResultElement> Value { get; }

        private int GetElementAtAsInt(
            IsIndexElement sIndexElement,
            IkIndexElement kIndexElement)
        {
            return this.Value
                .Where(x => x.sIndexElement == sIndexElement && x.kIndexElement == kIndexElement)
                .Select(x => x.Value)
                .SingleOrDefault();
        }

        public RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory,
            Ik k,
            Is s)
        {
            RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>> outerRedBlackTree = new RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>>();

            foreach (IsIndexElement sIndexElement in s.Value.Values)
            {
                RedBlackTree<INullableValue<int>, INullableValue<int>> innerRedBlackTree = new RedBlackTree<INullableValue<int>, INullableValue<int>>();

                foreach (IkIndexElement kIndexElement in k.Value.Values)
                {
                    innerRedBlackTree.Add(
                        kIndexElement.Value,
                        nullableValueFactory.Create<int>(
                            this.GetElementAtAsInt(
                                sIndexElement,
                                kIndexElement)));
                }

                outerRedBlackTree.Add(
                    sIndexElement.Value,
                    innerRedBlackTree);
            }

            return outerRedBlackTree;
        }
    }
}