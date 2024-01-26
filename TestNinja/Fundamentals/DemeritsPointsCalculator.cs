namespace TestNinja.Fundamentals;

public class DemeritsPointsCalculator
{
    private const int SpeedLimit = 65;
    private const int kmPerDemeritPoint = 5;
    public int CalculateDemeritPoints(int speed)
    {
        if (speed < 0)
            throw new ArgumentOutOfRangeException();

        if (speed <= SpeedLimit) return 0;

        return (speed - SpeedLimit) / kmPerDemeritPoint;
    }
}