using System.Collections;
using IteratorAndCompositePatterns.Contracts;

namespace IteratorAndCompositePatterns.Models
{
    public class CafeMenu : IMenu<MenuItem>
    {
        Dictionary<String, MenuItem> menuItems = new Dictionary<String, MenuItem>();
        public CafeMenu() {
            addItem("Veggie Burger and Air Fries",
                "Veggie burger on a whole wheat bun, lettuce, tomato, and fries",
                true, 3.99);
            addItem("Soup of the day",
                "A cup of the soup of the day, with a side salad",
                false, 3.69);
            addItem("Burrito",
                "A large burrito, with whole pinto beans, salsa, guacamole",
                true, 4.29);
        }
        public void addItem(String name, String description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            menuItems.Add(name, menuItem);
        }
        public IEnumerator CreateEnumerator()
        {
            return menuItems.Values.GetEnumerator();
        }

        public IEnumerator<MenuItem> CreateEnumeratorGeneric()
        {
            throw new NotImplementedException();
        }
    }
}