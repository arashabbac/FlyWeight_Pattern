namespace FlyWeight_Pattern.AlphabetFlyWeight
{
    public abstract class Alphabet
    {
        protected string character;

        public void Print(int x, int y, string color)
        {
            System.Console.WriteLine($"x : { x } y : { y } color : { color } { character }");
        }
    }
}
