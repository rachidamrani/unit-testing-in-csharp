using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests;

public class FizzBuzzTests
{
    [Test]
    public void GetOutput_WithIntDivisibleByFive_ReturnBuzz()
    {
        var result = FizzBuzz.GetOutput(10);
        Assert.That(result, Is.EqualTo("Buzz"));
    }

    [Test]
    public void GetOutput_WithIntDivisibleByThree_ReturnFizz()
    {
        var result = FizzBuzz.GetOutput(9);
        Assert.That(result, Is.EqualTo("Fizz"));
    }

    [Test]
    public void GetOutput_WithIntNotDivisibleByThreeAndFive_ReturnNumberToString()
    {
        var result = FizzBuzz.GetOutput(4);
        Assert.That(result, Is.EqualTo("4"));
    }
}
