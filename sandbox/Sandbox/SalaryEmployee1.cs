public class SalaryEmployee1: Employee1
{
    private float salary = 100f;
    public override float CalculatePay()
    {
        return salary;
    }
}