using System.Collections;

namespace IteratorAndCompositePatterns.Models
{
    public class DinnerMenuEnumerable : IEnumerator<MenuItem>
    {
        MenuItem[] _items;
        int position = 0;
        public DinnerMenuEnumerable(MenuItem[] items)
        {
            _items = items;
        }

        public object Current
        {
            get
            {
                MenuItem menuItem = _items[position];
                position = position + 1;
                return menuItem;
            }
        }

        MenuItem IEnumerator<MenuItem>.Current
        {
            get
            {
                MenuItem menuItem = _items[position];
                position = position + 1;
                return menuItem;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
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
    }
}