using Newtonsoft.Json;

namespace Relationship.Dependency;

public class Customer
{
    public string CustomerName { get; set; }
    private WithdrawCommand command;

    public Customer(string name)
    {
        CustomerName = name;
    }

    public void CreateWithDrawCommand(int withdrawMoney)
    {
        command = new WithdrawCommand(CustomerName, withdrawMoney);
    }

    public void CustomerWithDrawMoney(ATM atm)
    {
        Console.WriteLine("Here is your bill: " + JsonConvert.SerializeObject(atm.WithDrawMoney(command)));
    }
}