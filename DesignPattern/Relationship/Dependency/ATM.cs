namespace Relationship.Dependency;

public struct Street
{
    public string streetName { get; set; }
}

public struct Bill
{
    public string customerName { get; set; }
    public int withdrawMoney { get; set; }
    public Street ATMLocation { get; set; }
}

public class ATM
{
    private Street location = new Street(); 
    
    public ATM(string streetName)
    {
        location.streetName = streetName;
    }

    public Bill WithDrawMoney(WithdrawCommand command)
    {
        Bill bill = new Bill()
        {
            customerName = command.CustomerName,
            withdrawMoney = command.WithdrawMoney,
            ATMLocation = this.location,
        };
        
        return bill;
    }
}