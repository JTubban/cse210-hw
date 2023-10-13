// public class Account
// {
//     public int _balance = 0;
//     public void Deposit (int amount)
//     {
//         _balance += amount;
//     }
// }

using System.Data;

public class Account
{
    private List<int> _transactions = new List<int>();

    public void Deposit(int amount)
    {
        _transactions.Add(amount);
    }
}