using MorseCode;
using static System.Console;

namespace _3Pont
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Morse morse = new Morse(10);
            morse.DecodeS("ABC love you");

            ReadKey(true);
        }
    }
}
