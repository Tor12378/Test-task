using TestTask;

int result = FluentCalculator.One.Plus(FluentCalculator.Two).Minus(FluentCalculator.Three).Value; // result is 0
Console.WriteLine(result);