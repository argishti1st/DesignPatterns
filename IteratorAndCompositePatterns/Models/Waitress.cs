using System.Collections;
using IteratorAndCompositePatterns.Contracts;

namespace IteratorAndCompositePatterns.Models
{
    public class Waitress
    {
        MenuComponent _allMenus;

        public Waitress(MenuComponent allMenus)
        {
            _allMenus = allMenus;
        }

        public void PrintMenu()
        {
            _allMenus.Print();
        }

        // public void PrintMenu(IEnumerator enumerator)
        // {
        //     while(enumerator.MoveNext()){
        //         var item = enumerator.Current;
        //         var menuItem = item as MenuItem;
        //         if (menuItem != null)
        //         {
        //             Console.WriteLine($"Name: {menuItem.Name}, description: {menuItem.Desc}, price: {menuItem.Price}");
        //         }
        //     }
        // }
    }
}