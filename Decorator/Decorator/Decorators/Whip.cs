public class Whip : CondimentDecorator
{
    public Beverage _beverage{get; set;}
    public Whip(Beverage beverage)
    {
        _beverage = beverage;
    }

    public override string Description {get => _beverage.Description + ", Whip";}
    public override double Cost()
    {
        return _beverage.Cost() + 0.15;
    }
}