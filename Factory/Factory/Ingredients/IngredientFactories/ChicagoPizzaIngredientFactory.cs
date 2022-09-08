using Factory.Abstractions;
using Factory.Ingredients.Veggies;
using Factory.Ingredients.Toppings;

namespace Factory.Ingredients
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IDough CreateDough() {
            return new ThinCrustDough();
        }
        public ISauce CreateSauce() {
            return new MarinaraSauce();
        }
        public ICheese CreateCheese() {
            return new ReggianoCheese();
        }
        public List<IVeggies> CreateVeggies() {
            var veggies = new List<IVeggies>() { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
            return veggies;
        }
        public IPepperoni CreatePepperoni() {
            return new SlicedPepperoni();
        }
        public IClams CreateClam() {
            return new FreshClams();
        }
    }
}