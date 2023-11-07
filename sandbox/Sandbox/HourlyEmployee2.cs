public class HourlySalary2: IEmployee
{
    private float rate = 9f;
    private float hours = 100f;
    public float CalculatePay()
    {
        return rate * hours;
    }
}