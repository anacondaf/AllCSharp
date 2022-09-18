namespace Strategy_Pattern.Strategy;

public class CantFly : IFlyStrategy
{
    public string fly(string animalName)
    {
        return "The dog can't fly";
    }
}