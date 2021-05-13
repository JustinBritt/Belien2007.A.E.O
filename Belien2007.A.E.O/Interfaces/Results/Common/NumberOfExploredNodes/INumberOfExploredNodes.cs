namespace Belien2007.A.E.O.Interfaces.Results.Common.NumberOfExploredNodes
{
    public interface INumberOfExploredNodes
    {
        long Value { get; }

        long GetValueForOutputContext();
    }
}