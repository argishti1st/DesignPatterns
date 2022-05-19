using System.Collections;

namespace IteratorAndCompositePatterns.Contracts
{
    public interface IMenu<T>
    {
        IEnumerator<T> CreateEnumeratorGeneric();

        IEnumerator CreateEnumerator();
    }
}