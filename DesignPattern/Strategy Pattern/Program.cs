
namespace Strategy_Pattern
{
    public class Program
    {
        public static void Main()
        {
            Dog doggy = new Dog("teeser");
            doggy.Flying();
            
            Bird birdy = new Bird("birdy");
            birdy.Flying();
        }
    }
}