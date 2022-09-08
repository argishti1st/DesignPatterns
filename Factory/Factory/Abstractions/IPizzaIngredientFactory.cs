using Factory.Ingredients;

namespace Factory.Abstractions
{
    public interface IPizzaIngredientFactory
    {
         IDough CreateDough();
         ISauce CreateSauce();
         ICheese CreateCheese();
         List<IVeggies> CreateVeggies();
         IPepperoni CreatePepperoni();
         IClams CreateClam();
    }
}