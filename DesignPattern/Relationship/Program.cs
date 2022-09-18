using Relationship.Association;
using Relationship.Dependency;

public class Program
{
    public static void Main()
    {
        //Association
        Parent biden = new Parent(new List<Children> ()
        {
            new Children("Child1"){ Age = 10, Name = "Bill" }, 
            new Children("Child2") { Age= 5, Name = "Lisa"}
        });
        
        biden.ViewChildren().ForEach(child => Console.WriteLine("Biden's child are: " + child.Name));
        Console.Write("With delegate: \n");
        biden.CountChildrenTraditional(biden.ViewChildren);
        
        Console.Write("With Func: \n");
        biden.CountChildrenTraditional(biden.ViewChildren);
        
        
        //Dependency
        Customer a = new Customer("Nguyen Van A");

        Console.WriteLine("Insert your withdraw money: ");
        int withdrawMoney = Convert.ToInt32(Console.ReadLine());

        a.CreateWithDrawCommand(withdrawMoney);
        
        Console.WriteLine("------withdrawing-----");
        ATM atm1 = new ATM("Hai Ba Trung");
        a.CustomerWithDrawMoney(atm1);
    }
}