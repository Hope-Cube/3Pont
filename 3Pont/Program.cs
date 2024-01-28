using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Pont
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Morse morse = new Morse(12);
            Morse.Chars.A.Sound.Invoke();

        }
    }
}
