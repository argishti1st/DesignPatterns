public class Decaf : Beverage
{
    public Decaf()
    {
        Description = "Decaf coffee";
    }

    public override double Cost(){
        return 1.05;
    }
}
