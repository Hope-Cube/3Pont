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
                switch (c)
                {
                    case ' ':
                        _textList.Add("   ");
                        break;
                    case '.':
                        _textList.Add("       ");
                        break;
                    case 'A':
                        _textList.Add(A.Text);
                        break;
                    case 'B':
                        _textList.Add(B.Text);
                        break;
                    case 'C':
                        _textList.Add(C.Text);
                        break;
                    case 'D':
                        _textList.Add(D.Text);
                        break;
                    case 'E':
                        _textList.Add(E.Text);
                        break;
                    case 'F':
                        _textList.Add(F.Text);
                        break;
                    case 'G':
                        _textList.Add(G.Text);
                        break;
                    case 'H':
                        _textList.Add(H.Text);
                        break;
                    case 'I':
                        _textList.Add(I.Text);
                        break;
                    case 'J':
                        _textList.Add(J.Text);
                        break;
                    case 'K':
                        _textList.Add(K.Text);
                        break;
                    case 'L':
                        _textList.Add(L.Text);
                        break;
                    case 'M':
                        _textList.Add(M.Text);
                        break;
                    case 'N':
                        _textList.Add(N.Text);
                        break;
                    case 'O':
                        _textList.Add(O.Text);
                        break;
                    case 'P':
                        _textList.Add(P.Text);
                        break;
                    case 'Q':
                        _textList.Add(Q.Text);
                        break;
                    case 'R':
                        _textList.Add(R.Text);
                        break;
                    case 'S':
                        _textList.Add(S.Text);
                        break;
                    case 'T':
                        _textList.Add(T.Text);
                        break;
                    case 'U':
                        _textList.Add(U.Text);
                        break;
                    case 'V':
                        _textList.Add(V.Text);
                        break;
                    case 'W':
                        _textList.Add(W.Text);
                        break;
                    case 'X':
                        _textList.Add(X.Text);
                        break;
                    case 'Y':
                        _textList.Add(Y.Text);
                        break;
                    case 'Z':
                        _textList.Add(Z.Text);
                        break;
                    case '0':
                        _textList.Add(Zero.Text);
                        break;
                    case '1':
                        _textList.Add(One.Text);
                        break;
                    case '2':
                        _textList.Add(Two.Text);
                        break;
                    case '3':
                        _textList.Add(Three.Text);
                        break;
                    case '4':
                        _textList.Add(Four.Text);
                        break;
                    case '5':
                        _textList.Add(Five.Text);
                        break;
                    case '6':
                        _textList.Add(Six.Text);
                        break;
                    case '7':
                        _textList.Add(Seven.Text);
                        break;
                    case '8':
                        _textList.Add(Eight.Text);
                        break;
                    case '9':
                        _textList.Add(Nine.Text);
                        break;
                }
            }
            string eh = "";
            foreach (var item in _textList)
            {
                eh += item;
            }
            return eh;
        }
        public void DecodeS(string s)
        {
            _soundList = new List<Action>();
            foreach (char c in s.ToUpper())
            {
                switch (c)
                {
                    case ' ':
                        _soundList.Add(() => WB());
                        break;
                    case '.':
                        _soundList.Add(() => LB());
                        break;
                    case 'A':
                        _soundList.Add(A.Sound);
                        break;
                    case 'B':
                        _soundList.Add(B.Sound);
                        break;
                    case 'C':
                        _soundList.Add(C.Sound);
                        break;
                    case 'D':
                        _soundList.Add(D.Sound);
                        break;
                    case 'E':
                        _soundList.Add(E.Sound);
                        break;
                    case 'F':
                        _soundList.Add(F.Sound);
                        break;
                    case 'G':
                        _soundList.Add(G.Sound);
                        break;
                    case 'H':
                        _soundList.Add(H.Sound);
                        break;
                    case 'I':
                        _soundList.Add(I.Sound);
                        break;
                    case 'J':
                        _soundList.Add(J.Sound);
                        break;
                    case 'K':
                        _soundList.Add(K.Sound);
                        break;
                    case 'L':
                        _soundList.Add(L.Sound);
                        break;
                    case 'M':
                        _soundList.Add(M.Sound);
                        break;
                    case 'N':
                        _soundList.Add(N.Sound);
                        break;
                    case 'O':
                        _soundList.Add(O.Sound);
                        break;
                    case 'P':
                        _soundList.Add(P.Sound);
                        break;
                    case 'Q':
                        _soundList.Add(Q.Sound);
                        break;
                    case 'R':
                        _soundList.Add(R.Sound);
                        break;
                    case 'S':
                        _soundList.Add(S.Sound);
                        break;
                    case 'T':
                        _soundList.Add(T.Sound);
                        break;
                    case 'U':
                        _soundList.Add(U.Sound);
                        break;
                    case 'V':
                        _soundList.Add(V.Sound);
                        break;
                    case 'W':
                        _soundList.Add(W.Sound);
                        break;
                    case 'X':
                        _soundList.Add(X.Sound);
                        break;
                    case 'Y':
                        _soundList.Add(Y.Sound);
                        break;
                    case 'Z':
                        _soundList.Add(Z.Sound);
                        break;
                    case '0':
                        _soundList.Add(Zero.Sound);
                        break;
                    case '1':
                        _soundList.Add(One.Sound);
                        break;
                    case '2':
                        _soundList.Add(Two.Sound);
                        break;
                    case '3':
                        _soundList.Add(Three.Sound);
                        break;
                    case '4':
                        _soundList.Add(Four.Sound);
                        break;
                    case '5':
                        _soundList.Add(Five.Sound);
                        break;
                    case '6':
                        _soundList.Add(Six.Sound);
                        break;
                    case '7':
                        _soundList.Add(Seven.Sound);
                        break;
                    case '8':
                        _soundList.Add(Eight.Sound);
                        break;
                    case '9':
                        _soundList.Add(Nine.Sound);
                        break;
                }
            }
            foreach (var item in _soundList)
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