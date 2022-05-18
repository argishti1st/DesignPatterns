namespace TemplateMethodPattern.Models
{
    public abstract class CoffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            pourInCup();
            AddCondiments();
        }

        public void BoilWater(){
            Console.WriteLine("Water is boiling");
        }

        public void pourInCup(){
            Console.WriteLine("Pouring in cup");
        }

        public abstract void Brew();

        public abstract void AddCondiments();
    }
}