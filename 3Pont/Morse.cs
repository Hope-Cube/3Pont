using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _3Pont.Morse.Letter;
using static System.Console;
using static System.Threading.Thread;

namespace _3Pont
{
    internal class Morse
    {
        public class Letter
        {
            static private void SB()
            {
                Sleep(100);
            }static private void WB()
            {
                Sleep(300);
            }static private void LB()
            {
                Sleep(700);
            }
            public class A
            {
                public string Text => "· –";
                static public Action Sound => () => { Beep(700, 100); SB(); Beep(700, 300); };
            }
        }
    }
}

/*A   · –
B	– · · ·
C	– · – ·
D	– · ·
E	·
F	· · – ·
G	– – ·
H	· · · ·
I	· ·
J	· – – –
K	– · –
L	· – · ·
M	– –
N	– ·
O	– – –
P	· – – ·
Q	– – · –
R	· – ·
S	· · ·
T	–
U	· · –
V	· · · –
W	· – –
X	– · · –
Y	– · – –
Z	– – · ·

0	– – – – –
1	· – – – –
2	· · – – –
3	· · · – –
4	· · · · –
5	· · · · ·
6	– · · · ·
7	– – · · ·
8	– – – · ·
9	– – – – ·*/