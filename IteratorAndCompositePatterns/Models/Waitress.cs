using System.Collections;

namespace IteratorAndCompositePatterns.Models
{
    public class Waitress
    {
        private readonly DinnerMenu _dinnerMenu;

        public Waitress(DinnerMenu dinnerMenu)
        {
            _dinnerMenu = dinnerMenu;
        }

        public void PrintMenu()
        {
            var enumerable = _dinnerMenu.CreateEnumerable();

            PrintMenu<MenuItem>(enumerable);
        }

        public void PrintMenu<T>(IEnumerator<T> enumerable)
        {
            while(enumerable.MoveNext()){
                var item = enumerable.Current;
                var menuItem = item as MenuItem;
                if (menuItem != null)
                {
                    Console.WriteLine($"Name: {menuItem.Name}, description: {menuItem.Desc}, price: {menuItem.Price}");
                }
            }
        }
    }
}