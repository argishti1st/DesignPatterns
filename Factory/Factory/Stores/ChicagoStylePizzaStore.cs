using Factory.Abstractions;
using Factory.Pizzas;
using Factory.Ingredients;

namespace Factory.Stores
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        Pizza pizza = null;
        IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();
        public override Pizza CreatePizza(string type)
        {
            if (type.Equals("cheese")) {
                return new CheesePizza(ingredientFactory);
            } else if (type.Equals("veggie")) {
                return new VeggiePizza(ingredientFactory);
            } else if (type.Equals("clam")) {
                return new ClamPizza(ingredientFactory);
            } else if (type.Equals("pepperoni")) {
                return new PepperoniPizza(ingredientFactory);
            } else return null;
        }
    }
}