public class HourlyEmployee1: Employee1
{
    private float rate = 9f;
    private float hours = 100f;

    public override float CalculatePay()
    {
        return rate * hours;
    }
}