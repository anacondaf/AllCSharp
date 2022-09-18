using Strategy_Pattern.Strategy;

namespace Strategy_Pattern
{
    public class Animal
    {
        private string _name;
        public IFlyStrategy FlyStrategy;

        public string Name { get; set; }

        public Animal(string name)
        {
            this._name = name;
        }

        public void Flying()
        {
            Console.WriteLine(FlyStrategy.fly(this._name));
        }

        public void SetFlyStrategy(IFlyStrategy flyStrategy)
        {
            FlyStrategy = flyStrategy;
        }
    }
}

