public abstract class Employee1
{
    private string _employeeName;
    
    // Notice the abstract method doesn't have a body at all (not even an empty one)
    // and it is followed by a semicolon.
    public abstract float CalculatePay();
}