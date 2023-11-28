using System.Dynamic;

public class Customer: Address
{
    protected string _customerName;
    public string GetCustomerNameAndAddress()
    {
        return $@"
Name: {_customerName}
Adress: {_streetAddress}, {_city}, {_stateProvince}, {_country}
Live in USA: {_isInUsa}
        ";
    }
}