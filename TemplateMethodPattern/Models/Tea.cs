namespace TemplateMethodPattern.Models
{
    public class Tea : CoffeineBeverage
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Adding lemon");
        }

        public override void Brew()
        {
            Console.WriteLine("Steeping the tea bag into the water");
        }
    }
}