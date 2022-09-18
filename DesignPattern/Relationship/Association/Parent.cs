namespace Relationship.Association;

public class Parent
{
    private List<Children> _ourChildren;
    public List<Children> OurChildren { get; set; }
    
    public Parent(List<Children> ourChildren)
    {
        _ourChildren = ourChildren;
    }
    
    //Applying delegate to pass function ViewChildren as param for CountChildren
    public delegate List<Children> ViewChildrenDelegate();
    public void CountChildrenTraditional(ViewChildrenDelegate ViewChildren)
    {
        List<Children> listOfChildren = ViewChildren();
        
        Console.WriteLine("Number of children is: " + listOfChildren.Count());
    }
    
    /*
     * Func & Action are two replacements for Delegate
     * Action<T1 param1, T2 param2> <=> delegate void ActionDelegate( T1 param1, T2 param2 )
     * Func<T1 param1, T2 param2, T returnVal> <=> delegate T FuncDelegate( T1 param1, T2 param2 )
     */
    public void CountChildrenModern(Func<List<Children>> ViewChildren)
    {
        List<Children> listOfChildren = ViewChildren();
        
        Console.WriteLine("Number of children is: " + listOfChildren.Count());
    }

    public List<Children> ViewChildren()
    {
        return _ourChildren;
    }
}