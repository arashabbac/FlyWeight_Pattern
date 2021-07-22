using FlyWeight_Pattern.AlphabetFlyWeight;
using System;

namespace FlyWeight_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var a1 = AlphabetFactory.GetAlphabet("A");
            var a2 = AlphabetFactory.GetAlphabet("A");
            var b1 = AlphabetFactory.GetAlphabet("B");
            a1.Print(1, 2, "Red");
            a2.Print(2, 2, "Blue");
            b1.Print(3, 2, "Yellow");
        }
    }
}
