namespace Relationship.Dependency;

public class WithdrawCommand
{
    public string CustomerName { get; set; }
    public int WithdrawMoney { get; set; }

    public WithdrawCommand(string customerName, int withdrawMoney)
    {
        CustomerName = customerName;
        WithdrawMoney = withdrawMoney;
    }
}