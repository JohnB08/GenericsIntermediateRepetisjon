namespace GenericsIntermediateRepetisjon.Interfaces.List;

public interface IContains<in T>
{
    bool Contains(T obj);
}