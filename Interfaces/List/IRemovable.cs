namespace GenericsIntermediateRepetisjon.Interfaces.List;

public interface IRemoveable<in T>
{
    bool TryRemove(T obj);
    void Remove(T obj);
}
