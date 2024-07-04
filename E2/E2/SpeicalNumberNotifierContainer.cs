namespace E2;
public interface ISpecialNumberNotifierContainer
{
    void add(int x);
    event Action<int> SpecialNumberAdded;
    Func<int,bool> SpecialNumberIdentifier { get; set; }
    int this[int i] { get;  set; }
}