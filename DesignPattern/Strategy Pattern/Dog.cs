using Strategy_Pattern.Strategy;

namespace Strategy_Pattern
{
    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
            Name = name;
            
            //Set the flyStrategy CantFly for Dog
            FlyStrategy = new CantFly();
        }
    }
}
