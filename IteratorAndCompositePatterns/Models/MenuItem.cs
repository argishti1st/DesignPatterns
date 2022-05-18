namespace IteratorAndCompositePatterns.Models
{
    public class MenuItem
    {
        public string Name { get; set; }     
        public string Desc { get; set; }
        public bool IsVegan { get; set; }
        public double Price { get; set; }

        public MenuItem(string name, string desc, bool isVegan, double price)
        {
            Name = name;
            Desc = desc;
            IsVegan = isVegan;
            Price = price;
        }
    }
}