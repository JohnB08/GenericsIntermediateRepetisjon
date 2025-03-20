namespace GenericsIntermediateRepetisjon.Interfaces.List;

public interface IIndexable<T>
{
    T? this[int index] {get; set;}
}