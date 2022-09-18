namespace Relationship.Association;

public class Children
{
    public string Name { get; set; }
    public byte Age { get; set; }

    public Children(string name)
    {
        Name = name;
    }
}