using Strategy_Pattern.Strategy;

namespace Strategy_Pattern
{
    public class Bird : Animal
    {
        public Bird(string name) : base(name)
        {
            Name = name;

            //Set the flyStrategy CanFly for Bird
            FlyStrategy = new CanFly();
        }
    }
}

