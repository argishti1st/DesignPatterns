using Factory.Ingredients;

namespace Factory.Abstractions
{
    public abstract class  Pizza
    {
        public string Name { get; set; }
        public IDough Dough { get; set; }
        public ISauce Sauce { get; set; }
        public List<IVeggies> Veggies { get; set; }
        public ICheese Cheese { get; set; }
        public IPepperoni Pepperoni { get; set; }
        public IClams Clams { get; set; }
        public List<string> Toppings {get; set;} = new List<string>();
        public abstract void Prepare();

        public void Bake(){
            Console.WriteLine("Bake for 25 minutes at 350");
        }
        public void Cut(){
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }
        public void Box(){
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}