namespace Strategy_Pattern.Strategy;

public class CanFly : IFlyStrategy
{
    public string fly(string animalName)
    {
        return "The bird can fly";
    }
}