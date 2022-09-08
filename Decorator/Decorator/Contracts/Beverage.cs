public abstract class Beverage
{
    public virtual string Description { get; protected set; } = "Unknown Beverage";

    public Size Size { get; set; } = Size.TALL;

    public abstract double Cost();     
}