using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests;

[TestFixture]
public class FizzBuzzTests
{
    [Test]
    public void GetOutput_InputIsDivisibleByFive_ReturnBuzz()
    {
        var result = FizzBuzz.GetOutput(10);
        Assert.That(result, Is.EqualTo("Buzz"));
    }

    [Test]
    public void GetOutput_InputIsDivisibleByThree_ReturnFizz()
    {
        var result = FizzBuzz.GetOutput(9);
        Assert.That(result, Is.EqualTo("Fizz"));
    }

    [Test]
    public void GetOutput_InputIsDivisibleByThreeAndFive_ReturnNumberToString()
    {
        var result = FizzBuzz.GetOutput(15);
        Assert.That(result, Is.EqualTo("FizzBuzz"));
    }

    [Test]
    public void GetOutput_InputIsNotDivisibleByThreeAndFive_ReturnNumberToString()
    {
        var result = FizzBuzz.GetOutput(4);
        Assert.That(result, Is.EqualTo("4"));
    }
}
