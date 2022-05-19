using IteratorAndCompositePatterns.Contracts;

namespace IteratorAndCompositePatterns.Models
{
    public class MenuItem : MenuComponent
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

        public override string GetName()
        {
            return Name;
        }
        public override string GetDescription()
        {
            return Desc;
        }
        public override double GetPrice()
        {
            return Price;
        }
        public override bool IsVegetarian()
        {
            return IsVegan;
        }

        public override void Print() {
            Console.WriteLine(" " + GetName());

            if (IsVegetarian()) {
                Console.WriteLine("(v)");
            }

            Console.WriteLine(", " + GetPrice());
            Console.WriteLine(" -- " + GetDescription());
        }
    }
}