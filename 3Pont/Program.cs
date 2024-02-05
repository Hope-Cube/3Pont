using static System.Console;

namespace _3Pont
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Morse morse = new Morse(12);
            WriteLine(morse.DecodeT("ABC love you"));

            ReadKey(true);
        }
    }
}
