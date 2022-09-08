public class Soy : CondimentDecorator
{
    public Beverage _beverage{get; set;}
    public Soy(Beverage beverage)
    {
        _beverage = beverage;
    }

    public override string Description {get => _beverage.Description + ", Soy";}
    public override double Cost()
    {
        return _beverage.Cost() + 0.10;
    }
}