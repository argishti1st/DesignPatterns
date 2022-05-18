namespace TemplateMethodPattern.Models
{
    public class Coffee : CoffeineBeverage
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk");
        }

        public override void Brew()
        {
            Console.WriteLine("Brewing coffee grinds");
        }
    }
}