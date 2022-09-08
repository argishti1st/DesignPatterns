public class Mocha : CondimentDecorator
{
    public Beverage _beverage { get; set; }
    public Mocha(Beverage beverage)
    {
        _beverage = beverage;
    }

    public override string Description {get => _beverage.Description + ", Mocha";}

    public override double Cost()
    {
        double decoratorCost; 
        switch (_beverage.Size)
        {
            case Size.TALL:
                decoratorCost = 0.10;
                break;
            case Size.GRANDE:
                decoratorCost = 0.15;
                break;
            case Size.VENTI:
                decoratorCost = 0.20;
                break;
            default:
                decoratorCost = 0;
                break;
        }
        return _beverage.Cost() + decoratorCost;
    }
}