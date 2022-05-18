namespace IteratorAndCompositePatterns.Models
{
    public class DinnerMenu 
    {
        private static int MAX_ITEMS = 6;
        int numberOfItems = 0;

        public DinnerMenu()
        {
            MenuItems = new MenuItem[MAX_ITEMS];
            addItem("Vegetarian BLT",
            "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99);
            addItem("BLT",
            "Bacon with lettuce & tomato on whole wheat", false, 2.99);
            addItem("Soup of the day",
            "Soup of the day, with a side of potato salad", false, 3.29);
            addItem("Hotdog",
            "A hot dog, with sauerkraut, relish, onions, topped with cheese",
            false, 3.05);
            // a couple of other Diner Menu items added here
        }

        private void addItem(string name, string desc, bool isVegan, double price)
        {
            MenuItem menuItem = new MenuItem(name, desc, isVegan, price);

            if(numberOfItems >= MAX_ITEMS){
                Console.WriteLine("Dinner menu has reached it's max count");
            } else {
                MenuItems[numberOfItems] = menuItem;
                numberOfItems++;
            }
        }

        public MenuItem[] MenuItems { get; set; }

        public IEnumerator<MenuItem> CreateEnumerable()
        {
            return new DinnerMenuEnumerable(MenuItems);
        }
    }
}