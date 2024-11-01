namespace Bidirectional_Dictionary;

public class BiDictionary<T1, T2> where T1 : notnull where T2 : notnull
{
    private Dictionary<T1, T2> _forward = new();
    private Dictionary<T2, T1> _backward = new();
    public void Add(T1 key, T2 value)
    {
        _forward.Add(key, value);
        _backward.Add(value, key);
    }

    public void Add(T2 key, T1 value)
    {
        _backward.Add(key, value);
        _forward.Add(value, key);
    }
}