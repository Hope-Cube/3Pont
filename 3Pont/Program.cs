using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
