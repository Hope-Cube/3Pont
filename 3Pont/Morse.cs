using System;
using System.Collections.Generic;
using static _3Pont.Morse.Chars;
using static System.Console;
using static System.Threading.Thread;

namespace _3Pont
{
    internal class Morse
    {
        private static int _unit;
        public Morse(double wpm)
        {
            _unit = Convert.ToInt32(60 / (50 * wpm) * 1000);
        }
        public string DecodeT(string s)
        {
            List<string> textList = new List<string>();

            Dictionary<char, string> charToTextMap = new Dictionary<char, string>
    {
        {' ', "   "}, {'.', "       "},
        {'A', A.Text}, {'B', B.Text}, {'C', C.Text}, {'D', D.Text}, {'E', E.Text},
        {'F', F.Text}, {'G', G.Text}, {'H', H.Text}, {'I', I.Text}, {'J', J.Text},
        {'K', K.Text}, {'L', L.Text}, {'M', M.Text}, {'N', N.Text}, {'O', O.Text},
        {'P', P.Text}, {'Q', Q.Text}, {'R', R.Text}, {'S', S.Text}, {'T', T.Text},
        {'U', U.Text}, {'V', V.Text}, {'W', W.Text}, {'X', X.Text}, {'Y', Y.Text},
        {'Z', Z.Text}, {'0', Zero.Text}, {'1', One.Text}, {'2', Two.Text}, {'3', Three.Text},
        {'4', Four.Text}, {'5', Five.Text}, {'6', Six.Text}, {'7', Seven.Text}, {'8', Eight.Text},
        {'9', Nine.Text}
    };

            foreach (char c in s.ToUpper())
            {
                if (charToTextMap.ContainsKey(c))
                {
                    textList.Add(charToTextMap[c]);
                }
            }

            return string.Concat(textList);
        }

        public void DecodeS(string s)
        {
            List<Action> soundList = new List<Action>();

            Dictionary<char, Action> charToSoundMap = new Dictionary<char, Action>
    {
        {' ', WB}, {'.', LB},
        {'A', A.Sound}, {'B', B.Sound}, {'C', C.Sound}, {'D', D.Sound}, {'E', E.Sound},
        {'F', F.Sound}, {'G', G.Sound}, {'H', H.Sound}, {'I', I.Sound}, {'J', J.Sound},
        {'K', K.Sound}, {'L', L.Sound}, {'M', M.Sound}, {'N', N.Sound}, {'O', O.Sound},
        {'P', P.Sound}, {'Q', Q.Sound}, {'R', R.Sound}, {'S', S.Sound}, {'T', T.Sound},
        {'U', U.Sound}, {'V', V.Sound}, {'W', W.Sound}, {'X', X.Sound}, {'Y', Y.Sound},
        {'Z', Z.Sound}, {'0', Zero.Sound}, {'1', One.Sound}, {'2', Two.Sound}, {'3', Three.Sound},
        {'4', Four.Sound}, {'5', Five.Sound}, {'6', Six.Sound}, {'7', Seven.Sound}, {'8', Eight.Sound},
        {'9', Nine.Sound}
    };

            foreach (char c in s.ToUpper())
            {
                if (charToSoundMap.TryGetValue(c, out var soundAction))
                {
                    soundList.Add(soundAction);
                }
            }

            foreach (var item in soundList)
            {
                item.Invoke();
            }
        }
        public class Chars
        {
            static private void SB()
            {
                Sleep(_unit);
            }
            static internal void WB()
            {
                Sleep(3 * _unit);
            }
            static internal void LB()
            {
                Sleep(7 * _unit);
            }
            static private void Ti()
            {
                Beep(700, _unit);
            }
            static private void Ta()
            {
                Beep(700, 3 * _unit);
            }
            public class A
            {
                public char Character => 'A';
                public static string Text => "° –";
                public static Action Sound => () => { Ti(); SB(); Ta(); };
            }
            public class B
            {
                public char Character => 'B';
                public static string Text => "– ° ° °";
                public static Action Sound => () => { Ta(); SB(); Ti(); SB(); Ti(); SB(); Ti(); };
            }
            public class C
            {
                public char Character => 'C';
                public static string Text => "– ° – °";
                public static Action Sound => () => { Ta(); SB(); Ti(); SB(); Ta(); SB(); Ti(); };
            }
            public class D
            {
                public char Character => 'D';
                public static string Text => "– ° °";
                public static Action Sound => () => { Ta(); SB(); Ti(); SB(); Ti(); };
            }
            public class E
            {
                public char Character => 'E';
                public static string Text => "°";
                public static Action Sound => () => { Ti(); };
            }
            public class F
            {
                public char Character => 'F';
                public static string Text => "° ° – °";
                public static Action Sound => () => { Ti(); SB(); Ti(); SB(); Ta(); SB(); Ti(); };
            }
            public class G
            {
                public char Character => 'G';
                public static string Text => "– – °";
                public static Action Sound => () => { Ta(); SB(); Ta(); SB(); Ti(); };
            }
            public class H
            {
                public char Character => 'H';
                public static string Text => "° ° ° °";
                public static Action Sound => () => { Ti(); SB(); Ti(); SB(); Ti(); SB(); Ti(); };
            }
            public class I
            {
                public char Character => 'I';
                public static string Text => "° °";
                public static Action Sound => () => { Ti(); SB(); Ti(); };
            }
            public class J
            {
                public char Character => 'J';
                public static string Text => "° – – –";
                public static Action Sound => () => { Ti(); SB(); Ta(); SB(); Ta(); SB(); Ta(); };
            }
            public class K
            {
                public char Character => 'K';
                public static string Text => "– ° –";
                public static Action Sound => () => { Ta(); SB(); Ti(); SB(); Ta(); };
            }
            public class L
            {
                public char Character => 'L';
                public static string Text => "° – ° °";
                public static Action Sound => () => { Ti(); SB(); Ta(); SB(); Ti(); SB(); Ti(); };
            }
            public class M
            {
                public char Character => 'M';
                public static string Text => "– –";
                public static Action Sound => () => { Ta(); SB(); Ta(); };
            }
            public class N
            {
                public char Character => 'N';
                public static string Text => "– °";
                public static Action Sound => () => { Ta(); SB(); Ti(); };
            }
            public class O
            {
                public char Character => 'O';
                public static string Text => "– – –";
                public static Action Sound => () => { Ta(); SB(); Ta(); SB(); Ta(); };
            }
            public class P
            {
                public char Character => 'P';
                public static string Text => "° – – °";
                public static Action Sound => () => { Ti(); SB(); Ta(); SB(); Ta(); SB(); Ti(); };
            }
            public class Q
            {
                public char Character => 'Q';
                public static string Text => "– – ° –";
                public static Action Sound => () => { Ta(); SB(); Ta(); SB(); Ti(); SB(); Ta(); };
            }
            public class R
            {
                public char Character => 'R';
                public static string Text => "° – °";
                public static Action Sound => () => { Ti(); SB(); Ta(); SB(); Ti(); };
            }
            public class S
            {
                public char Character => 'S';
                public static string Text => "° ° °";
                public static Action Sound => () => { Ti(); SB(); Ti(); SB(); Ti(); };
            }
            public class T
            {
                public char Character => 'T';
                public static string Text => "–";
                public static Action Sound => () => { Ta(); };
            }
            public class U
            {
                public char Character => 'U';
                public static string Text => "° ° –";
                public static Action Sound => () => { Ti(); SB(); Ti(); SB(); Ta(); };
            }
            public class V
            {
                public char Character => 'V';
                public static string Text => "° ° ° –";
                public static Action Sound => () => { Ti(); SB(); Ti(); SB(); Ti(); SB(); Ta(); };
            }
            public class W
            {
                public char Character => 'W';
                public static string Text => "° – –";
                public static Action Sound => () => { Ti(); SB(); Ta(); SB(); Ta(); };
            }
            public class X
            {
                public char Character => 'X';
                public static string Text => "– ° ° –";
                public static Action Sound => () => { Ta(); SB(); Ti(); SB(); Ti(); SB(); Ta(); };
            }
            public class Y
            {
                public char Character => 'Y';
                public static string Text => "– ° – –";
                public static Action Sound => () => { Ta(); SB(); Ti(); SB(); Ta(); SB(); Ta(); };
            }
            public class Z
            {
                public char Character => 'Z';
                public static string Text => "– – ° °";
                public static Action Sound => () => { Ta(); SB(); Ta(); SB(); Ti(); SB(); Ti(); };
            }
            public class Zero
            {
                public char Character => '0';
                public static string Text => "– – – – –";
                public static Action Sound => () => { Ta(); SB(); Ta(); SB(); Ta(); SB(); Ta(); SB(); Ta(); };
            }
            public class One
            {
                public char Character => '1';
                public static string Text => "° – – – –";
                public static Action Sound => () => { Ti(); SB(); Ta(); SB(); Ta(); SB(); Ta(); SB(); Ta(); };
            }
            public class Two
            {
                public char Character => '2';
                public static string Text => "° ° – – –";
                public static Action Sound => () => { Ti(); SB(); Ti(); SB(); Ta(); SB(); Ta(); SB(); Ta(); };
            }
            public class Three
            {
                public char Character => '3';
                public static string Text => "° ° ° – –";
                public static Action Sound => () => { Ti(); SB(); Ti(); SB(); Ti(); SB(); Ta(); SB(); Ta(); };
            }
            public class Four
            {
                public char Character => '4';
                public static string Text => "° ° ° ° –";
                public static Action Sound => () => { Ti(); SB(); Ti(); SB(); Ti(); SB(); Ti(); SB(); Ta(); };
            }
            public class Five
            {
                public char Character => '5';
                public static string Text => "° ° ° ° °";
                public static Action Sound => () => { Ti(); SB(); Ti(); SB(); Ti(); SB(); Ti(); SB(); Ti(); };
            }
            public class Six
            {
                public char Character => '6';
                public static string Text => "– ° ° ° °";
                public static Action Sound => () => { Ta(); SB(); Ti(); SB(); Ti(); SB(); Ti(); SB(); Ti(); };
            }
            public class Seven
            {
                public char Character => '7';
                public static string Text => "– – ° ° °";
                public static Action Sound => () => { Ta(); SB(); Ta(); SB(); Ti(); SB(); Ti(); SB(); Ti(); };
            }
            public class Eight
            {
                public char Character => '8';
                public static string Text => "– – – ° °";
                public static Action Sound => () => { Ta(); SB(); Ta(); SB(); Ta(); SB(); Ti(); SB(); Ti(); };
            }
            public class Nine
            {
                public char Character => '9';
                public static string Text => "– – – – °";
                public static Action Sound => () => { Ta(); SB(); Ta(); SB(); Ta(); SB(); Ta(); SB(); Ti(); };
            }
        }
    }
}