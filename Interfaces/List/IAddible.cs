namespace GenericsIntermediateRepetisjon.Interfaces.List;

public interface IAddible<in T>
{
    void Add(T obj);
    void AddFirst(T obj);
}