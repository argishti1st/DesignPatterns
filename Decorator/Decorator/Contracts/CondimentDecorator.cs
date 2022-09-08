public abstract class CondimentDecorator : Beverage
{
    public abstract override string Description { get; }

    public Size Size { get => base.Size; }
}