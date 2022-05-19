using System.Collections;
using IteratorAndCompositePatterns.Contracts;

namespace IteratorAndCompositePatterns.Models
{
    public class PancakeHouseMenu : IMenu<MenuItem>
    {
        public ArrayList MenuItems { get; set; }

        public PancakeHouseMenu()
        {
            MenuItems = new ArrayList();
            addItem("K&B's Pancake Breakfast", "Pancakes with scrambled eggs and toast", true, 2.99);
            
            addItem("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage", false, 2.99);
            
            addItem("Blueberry Pancakes", "Pancakes made with fresh blueberries", true, 3.49);
            
            addItem("Waffles", "Waffles with your choice of blueberries or strawberries", true, 3.59);
        }

        private void addItem(string name, string desc, bool isVegan, double price)
        {
            MenuItem menuItem = new MenuItem(name, desc, isVegan, price);

            MenuItems.Add(menuItem);
        }

        public IEnumerator CreateEnumerator()
        {
            return MenuItems.GetEnumerator();
        }

        public IEnumerator<MenuItem> CreateEnumeratorGeneric()
        {
            throw new NotImplementedException();
        }
    }
}