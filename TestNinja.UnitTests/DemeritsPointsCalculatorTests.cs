using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests;
public class DemeritsPointsCalculatorTests
{
    private DemeritsPointsCalculator _demeritsPointsCalculator;
    [SetUp]
    public void SetUp()
    {
        _demeritsPointsCalculator = new();
    }

    [Test]
    public void CalculateDemeritPoints_InputIsNegatif_ThrowArgumentOutOfRangeException()
    {
        Assert.That(
            () =>
        _demeritsPointsCalculator.CalculateDemeritPoints(-1),
        Throws.Exception.TypeOf<ArgumentOutOfRangeException>()
        );
    }

    [Test]
    public void CalculateDemeritPoints_InputIsLessThanOrEqualSpeedLimit_ReturnZero()
    {
        var result = _demeritsPointsCalculator.CalculateDemeritPoints(65);
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void CalculateDemeritPoints_InputIsGreaterThanSpeedLimit_ReturnDemeritPoints()
    {
        var result = _demeritsPointsCalculator.CalculateDemeritPoints(84);

        Assert.That(result, Is.EqualTo(3));
    }

}