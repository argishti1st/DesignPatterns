using System.Collections;

namespace IteratorAndCompositePatterns.Models
{
    public class DinnerMenuEnumerable : IEnumerable<MenuItem>, IEnumerator<MenuItem>
    {
        MenuItem[] _items;
        int position = 0;
        public DinnerMenuEnumerable(MenuItem[] items)
        {
            _items = items;
        }

        public MenuItem Current
        {
            get
            {
                MenuItem menuItem = _items[position];
                position = position + 1;
                return menuItem;
            }
        }

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<MenuItem> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            if (position >= _items.Length || _items[position] == null) {
                return false;
                } else {
                return true;
}
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}