namespace TestTask;

public class FluentCalculator
{
    private int _value;

    private FluentCalculator(int value)
    {
        _value = value;
    }

    public static FluentCalculator Zero => new FluentCalculator(0);
    public static FluentCalculator One => new FluentCalculator(1);
    public static FluentCalculator Two => new FluentCalculator(2);
    public static FluentCalculator Three => new FluentCalculator(3);
    public static FluentCalculator Four => new FluentCalculator(4);
    public static FluentCalculator Five => new FluentCalculator(5);
    public static FluentCalculator Six => new FluentCalculator(6);
    public static FluentCalculator Seven => new FluentCalculator(7);
    public static FluentCalculator Eight => new FluentCalculator(8);
    public static FluentCalculator Nine => new FluentCalculator(9);
    public static FluentCalculator Ten => new FluentCalculator(10);

    public FluentCalculator Plus(FluentCalculator other) => new FluentCalculator(_value + other._value);
    public FluentCalculator Minus(FluentCalculator other) => new FluentCalculator(_value - other._value);
    public FluentCalculator Times(FluentCalculator other) => new FluentCalculator(_value * other._value);
    public FluentCalculator DividedBy(FluentCalculator other)
    {
        if (other._value == 0)
            throw new DivideByZeroException();
        return new FluentCalculator(_value / other._value);
    }

    public int Value => _value;
}