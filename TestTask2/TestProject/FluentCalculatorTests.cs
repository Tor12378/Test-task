using TestTask;

namespace TestProject;

[TestFixture]
public class FluentCalculatorTests
{
    [Test]
    public void Plus_ShouldAddTwoNumbers()
    {
        var result = FluentCalculator.One.Plus(FluentCalculator.Two).Value;
        Assert.AreEqual(3, result);
    }

    [Test]
    public void Minus_ShouldSubtractTwoNumbers()
    {
        var result = FluentCalculator.Three.Minus(FluentCalculator.One).Value;
        Assert.AreEqual(2, result);
    }

    [Test]
    public void Times_ShouldMultiplyTwoNumbers()
    {
        var result = FluentCalculator.Four.Multiplication(FluentCalculator.Two).Value;
        Assert.AreEqual(8, result);
    }

    [Test]
    public void DividedBy_ShouldDivideTwoNumbers()
    {
        var result = FluentCalculator.Eight.DividedBy(FluentCalculator.Two).Value;
        Assert.AreEqual(4, result);
    }

    [Test]
    public void DividedBy_ShouldThrowExceptionWhenDividedByZero()
    {
        Assert.Throws<DivideByZeroException>(() => FluentCalculator.Five.DividedBy(FluentCalculator.Zero));
    }
}