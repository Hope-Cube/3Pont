using System;
using System.Collections.Generic;
using static System.Console;
using static System.Threading.Thread;

namespace MorseCode
{
    public class Morse
    {
        private static int _unit;
        public List<string> _textList;
        public List<Action> _soundList;

        public Morse(double wpm)
        {
            _unit = Convert.ToInt32(60 / (50 * wpm) * 1000);
        }

        public string DecodeT(string s)
        {
            _textList = new List<string>();

            foreach (char c in s.ToUpper())
            {
                if (CharToText.ContainsKey(c))
                {
                    _textList.Add(CharToText[c]);
                }
                else if (c == ' ')
                {
                    _textList.Add("   ");
                }
                else if (c == '.')
                {
                    _textList.Add("       ");
                }
            }

            return string.Concat(_textList);
        }

        public void DecodeS(string s)
        {
            _soundList = new List<Action>();

            foreach (char c in s.ToUpper())
            {
                if (CharToSound.ContainsKey(c))
                {
                    _soundList.Add(CharToSound[c]);
                }
                else if (c == ' ')
                {
                    _soundList.Add(() => WB());
                }
                else if (c == '.')
                {
                    _soundList.Add(() => LB());
                }
            }

            foreach (var item in _soundList)
            {
                item.Invoke();
            }
        }

        private static readonly Dictionary<char, string> CharToText = new Dictionary<char, string>
        {
            {' ', "   "},
            {'.', "       "},
            {'A', Chars.A.Text}, {'B', Chars.B.Text}, {'C', Chars.C.Text}, {'D', Chars.D.Text}, {'E', Chars.E.Text},
            {'F', Chars.F.Text}, {'G', Chars.G.Text}, {'H', Chars.H.Text}, {'I', Chars.I.Text}, {'J', Chars.J.Text},
            {'K', Chars.K.Text}, {'L', Chars.L.Text}, {'M', Chars.M.Text}, {'N', Chars.N.Text}, {'O', Chars.O.Text},
            {'P', Chars.P.Text}, {'Q', Chars.Q.Text}, {'R', Chars.R.Text}, {'S', Chars.S.Text}, {'T', Chars.T.Text},
            {'U', Chars.U.Text}, {'V', Chars.V.Text}, {'W', Chars.W.Text}, {'X', Chars.X.Text}, {'Y', Chars.Y.Text},
            {'Z', Chars.Z.Text}, {'0', Chars.Zero.Text}, {'1', Chars.One.Text}, {'2', Chars.Two.Text}, {'3', Chars.Three.Text},
            {'4', Chars.Four.Text}, {'5', Chars.Five.Text}, {'6', Chars.Six.Text}, {'7', Chars.Seven.Text}, {'8', Chars.Eight.Text},
            {'9', Chars.Nine.Text},
        };

        private static readonly Dictionary<char, Action> CharToSound = new Dictionary<char, Action>
        {
            {' ', () => WB()},
            {'.', () => LB()},
            {'A', Chars.A.Sound}, {'B', Chars.B.Sound}, {'C', Chars.C.Sound}, {'D', Chars.D.Sound}, {'E', Chars.E.Sound},
            {'F', Chars.F.Sound}, {'G', Chars.G.Sound}, {'H', Chars.H.Sound}, {'I', Chars.I.Sound}, {'J', Chars.J.Sound},
            {'K', Chars.K.Sound}, {'L', Chars.L.Sound}, {'M', Chars.M.Sound}, {'N', Chars.N.Sound}, {'O', Chars.O.Sound},
            {'P', Chars.P.Sound}, {'Q', Chars.Q.Sound}, {'R', Chars.R.Sound}, {'S', Chars.S.Sound}, {'T', Chars.T.Sound},
            {'U', Chars.U.Sound}, {'V', Chars.V.Sound}, {'W', Chars.W.Sound}, {'X', Chars.X.Sound}, {'Y', Chars.Y.Sound},
            {'Z', Chars.Z.Sound}, {'0', Chars.Zero.Sound}, {'1', Chars.One.Sound}, {'2', Chars.Two.Sound}, {'3', Chars.Three.Sound},
            {'4', Chars.Four.Sound}, {'5', Chars.Five.Sound}, {'6', Chars.Six.Sound}, {'7', Chars.Seven.Sound}, {'8', Chars.Eight.Sound},
            {'9', Chars.Nine.Sound},
        };
        private static void SB() => Sleep(_unit);
        internal static void WB() => Sleep(3 * _unit);
        internal static void LB() => Sleep(7 * _unit);
        private static void Ti() => Beep(700, _unit);
        private static void Ta() => Beep(700, 3 * _unit);
        internal class Chars
        {
            public class A
            {
                public static string Text => "° –";
                public static Action Sound => () => { Ti(); SB(); Ta(); };
            }

            public class B
            {
                public static string Text => "– ° ° °";
                public static Action Sound => () => { Ta(); SB(); Ti(); SB(); Ti(); SB(); Ti(); };
            }

            public class C
            {
                public static string Text => "– ° – °";
                public static Action Sound => () => { Ta(); SB(); Ti(); SB(); Ta(); SB(); Ti(); };
            }

            public class D
            {
                public static string Text => "– ° °";
                public static Action Sound => () => { Ta(); SB(); Ti(); SB(); Ti(); };
            }

            public class E
            {
                public static string Text => "°";
                public static Action Sound => () => { Ti(); };
            }

            public class F
            {
                public static string Text => "° ° – °";
                public static Action Sound => () => { Ti(); SB(); Ti(); SB(); Ta(); SB(); Ti(); };
            }

            public class G
            {
                public static string Text => "– – °";
                public static Action Sound => () => { Ta(); SB(); Ta(); SB(); Ti(); };
            }

            public class H
            {
                public static string Text => "° ° ° °";
                public static Action Sound => () => { Ti(); SB(); Ti(); SB(); Ti(); SB(); Ti(); };
            }

            public class I
            {
                public static string Text => "° °";
                public static Action Sound => () => { Ti(); SB(); Ti(); };
            }

            public class J
            {
                public static string Text => "° – – –";
                public static Action Sound => () => { Ti(); SB(); Ta(); SB(); Ta(); SB(); Ta(); };
            }

            public class K
            {
                public static string Text => "– ° –";
                public static Action Sound => () => { Ta(); SB(); Ti(); SB(); Ta(); };
            }

            public class L
            {
                public static string Text => "° – ° °";
                public static Action Sound => () => { Ti(); SB(); Ta(); SB(); Ti(); SB(); Ti(); };
            }

            public class M
            {
                public static string Text => "– –";
                public static Action Sound => () => { Ta(); SB(); Ta(); };
            }

            public class N
            {
                public static string Text => "– °";
                public static Action Sound => () => { Ta(); SB(); Ti(); };
            }

            public class O
            {
                public static string Text => "– – –";
                public static Action Sound => () => { Ta(); SB(); Ta(); SB(); Ta(); };
            }

            public class P
            {
                public static string Text => "° – – °";
                public static Action Sound => () => { Ti(); SB(); Ta(); SB(); Ta(); SB(); Ti(); };
            }

            public class Q
            {
                public static string Text => "– – ° –";
                public static Action Sound => () => { Ta(); SB(); Ta(); SB(); Ti(); SB(); Ta(); };
            }

            public class R
            {
                public static string Text => "° – °";
                public static Action Sound => () => { Ti(); SB(); Ta(); SB(); Ti(); };
            }

            public class S
            {
                public static string Text => "° ° °";
                public static Action Sound => () => { Ti(); SB(); Ti(); SB(); Ti(); };
            }

            public class T
            {
                public static string Text => "–";
                public static Action Sound => () => { Ta(); };
            }

            public class U
            {
                public static string Text => "° ° –";
                public static Action Sound => () => { Ti(); SB(); Ti(); SB(); Ta(); };
            }

            public class V
            {
                public static string Text => "° ° ° –";
                public static Action Sound => () => { Ti(); SB(); Ti(); SB(); Ti(); SB(); Ta(); };
            }

            public class W
            {
                public static string Text => "° – –";
                public static Action Sound => () => { Ti(); SB(); Ta(); SB(); Ta(); };
            }

            public class X
            {
                public static string Text => "– ° ° –";
                public static Action Sound => () => { Ta(); SB(); Ti(); SB(); Ti(); SB(); Ta(); };
            }

            public class Y
            {
                public static string Text => "– ° – –";
                public static Action Sound => () => { Ta(); SB(); Ti(); SB(); Ta(); SB(); Ta(); };
            }

            public class Z
            {
                public static string Text => "– – ° °";
                public static Action Sound => () => { Ta(); SB(); Ta(); SB(); Ti(); SB(); Ti(); };
            }

            public class Zero
            {
                public static string Text => "– – – – –";
                public static Action Sound => () => { Ta(); SB(); Ta(); SB(); Ta(); SB(); Ta(); SB(); Ta(); };
            }

            public class One
            {
                public static string Text => "° – – – –";
                public static Action Sound => () => { Ti(); SB(); Ta(); SB(); Ta(); SB(); Ta(); SB(); Ta(); };
            }

            public class Two
            {
                public static string Text => "° ° – – –";
                public static Action Sound => () => { Ti(); SB(); Ti(); SB(); Ta(); SB(); Ta(); SB(); Ta(); };
            }

            public class Three
            {
                public static string Text => "° ° ° – –";
                public static Action Sound => () => { Ti(); SB(); Ti(); SB(); Ti(); SB(); Ta(); SB(); Ta(); };
            }

            public class Four
            {
                public static string Text => "° ° ° ° –";
                public static Action Sound => () => { Ti(); SB(); Ti(); SB(); Ti(); SB(); Ti(); SB(); Ta(); };
            }

            public class Five
            {
                public static string Text => "° ° ° ° °";
                public static Action Sound => () => { Ti(); SB(); Ti(); SB(); Ti(); SB(); Ti(); SB(); Ti(); };
            }

            public class Six
            {
                public static string Text => "– ° ° ° °";
                public static Action Sound => () => { Ta(); SB(); Ti(); SB(); Ti(); SB(); Ti(); SB(); Ti(); };
            }

            public class Seven
            {
                public static string Text => "– – ° ° °";
                public static Action Sound => () => { Ta(); SB(); Ta(); SB(); Ti(); SB(); Ti(); SB(); Ti(); };
            }

            public class Eight
            {
                public static string Text => "– – – ° °";
                public static Action Sound => () => { Ta(); SB(); Ta(); SB(); Ta(); SB(); Ti(); SB(); Ti(); };
            }

            public class Nine
            {
                public static string Text => "– – – – °";
                public static Action Sound => () => { Ta(); SB(); Ta(); SB(); Ta(); SB(); Ta(); SB(); Ti(); };
            }
        }
    }
}