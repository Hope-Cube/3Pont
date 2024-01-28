using System;
using static System.Console;
using static System.Threading.Thread;

namespace _3Pont
{
    internal class Morse
    {
        public class Chars
        {
            static private void SB()
            {
                Sleep(100);
            }
            static private void WB()
            {
                Sleep(300);
            }
            static private void LB()
            {
                Sleep(700);
            }
            static private void Ti()
            {
                Beep(700, 100);
            }
            static private void Ta()
            {
                Beep(700, 300);
            }

            public class A //A   · –
            {
                public string Text => "· –";
                static public Action Sound => () => { Ti(); SB(); Ta(); };
            }
            public class B //B	– · · ·
            {
                public string Text => "– · · ·";
                static public Action Sound => () => { Ta(); SB(); Ti(); SB(); Ti(); SB(); Ti(); };
            }
            public class C //C	– · – ·
            {
                public string Text => "– · – ·";
                static public Action Sound => () => { Ta(); SB(); Ti(); SB(); Ta(); SB(); Ti(); };
            }
            public class D //D	– · ·
            {
                public string Text => "– · ·";
                static public Action Sound => () => { Beep(700, 100); SB(); Beep(700, 300); };
            }
            public class E //E	·
            {
                public string Text => "·";
                static public Action Sound => () => { Beep(700, 100); SB(); Beep(700, 300); };
            }
            public class F //F	· · – ·
            {
                public string Text => "· · – ·";
                static public Action Sound => () => { Beep(700, 100); SB(); Beep(700, 300); };
            }
            public class G //G	– – ·
            {
                public string Text => "– – ·";
                static public Action Sound => () => { Beep(700, 100); SB(); Beep(700, 300); };
            }
            public class H //H	· · · ·
            {
                public string Text => "· · · ·";
                static public Action Sound => () => { Beep(700, 100); SB(); Beep(700, 300); };
            }
            public class I //I	· ·
            {
                public string Text => "· ·";
                static public Action Sound => () => { Beep(700, 100); SB(); Beep(700, 300); };
            }
            public class J //J	· – – –
            {
                public string Text => "· – – –";
                static public Action Sound => () => { Beep(700, 100); SB(); Beep(700, 300); };
            }
            public class K //K	– · –
            {
                public string Text => "– · –";
                static public Action Sound => () => { Beep(700, 100); SB(); Beep(700, 300); };
            }
            public class L //L	· – · ·
            {
                public string Text => "· – · ·";
                static public Action Sound => () => { Beep(700, 100); SB(); Beep(700, 300); };
            }
            public class M //M	– –
            {
                public string Text => "– –";
                static public Action Sound => () => { Beep(700, 100); SB(); Beep(700, 300); };
            }
            public class N //N	– ·
            {
                public string Text => "– ·";
                static public Action Sound => () => { Beep(700, 100); SB(); Beep(700, 300); };
            }
            public class O //O	– – –
            {
                public string Text => "– – –";
                static public Action Sound => () => { Beep(700, 100); SB(); Beep(700, 300); };
            }
            public class P //P	· – – ·
            {
                public string Text => "· – – ·";
                static public Action Sound => () => { Beep(700, 100); SB(); Beep(700, 300); };
            }
            public class Q //Q	– – · –
            {
                public string Text => "– – · –";
                static public Action Sound => () => { Beep(700, 100); SB(); Beep(700, 300); };
            }
            public class R //R	· – ·
            {
                public string Text => "· – ·";
                static public Action Sound => () => { Beep(700, 100); SB(); Beep(700, 300); };
            }
            public class S //S	· · ·
            {
                public string Text => "· · ·";
                static public Action Sound => () => { Beep(700, 100); SB(); Beep(700, 300); };
            }
            public class T //T	–
            {
                public string Text => "–";
                static public Action Sound => () => { Beep(700, 100); SB(); Beep(700, 300); };
            }
            public class U //U	· · –
            {
                public string Text => "· · –";
                static public Action Sound => () => { Beep(700, 100); SB(); Beep(700, 300); };
            }
            public class V //V	· · · –
            {
                public string Text => "· · · –";
                static public Action Sound => () => { Beep(700, 100); SB(); Beep(700, 300); };
            }
            public class W //W	· – –
            {
                public string Text => "· – –";
                static public Action Sound => () => { Beep(700, 100); SB(); Beep(700, 300); };
            }
            public class X //X	– · · –
            {
                public string Text => "– · · –";
                static public Action Sound => () => { Beep(700, 100); SB(); Beep(700, 300); };
            }
            public class Y //Y	– · – –
            {
                public string Text => "– · – –";
                static public Action Sound => () => { Beep(700, 100); SB(); Beep(700, 300); };
            }
            public class Z //Z	– – · ·
            {
                public string Text => "– – · ·";
                static public Action Sound => () => { Beep(700, 100); SB(); Beep(700, 300); };
            }

            public class Zero //0	– – – – –
            {
                public string Text => "– – – – –";
                static public Action Sound => () => { Beep(700, 100); SB(); Beep(700, 300); };
            }
            public class One //1	· – – – –
            {
                public string Text => "· – – – –";
                static public Action Sound => () => { Beep(700, 100); SB(); Beep(700, 300); };
            }
            public class Two //2	· · – – –
            {
                public string Text => "· · – – –";
                static public Action Sound => () => { Beep(700, 100); SB(); Beep(700, 300); };
            }
            public class Three //3	· · · – –
            {
                public string Text => "· · · – –";
                static public Action Sound => () => { Beep(700, 100); SB(); Beep(700, 300); };
            }
            public class Four //4	· · · · –
            {
                public string Text => "· · · · –";
                static public Action Sound => () => { Beep(700, 100); SB(); Beep(700, 300); };
            }
            public class Five //5	· · · · ·
            {
                public string Text => "· · · · ·";
                static public Action Sound => () => { Beep(700, 100); SB(); Beep(700, 300); };
            }
            public class Six //6	– · · · ·
            {
                public string Text => "– · · · ·";
                static public Action Sound => () => { Beep(700, 100); SB(); Beep(700, 300); };
            }
            public class Seven //7	– – · · ·
            {
                public string Text => "– – · · ·";
                static public Action Sound => () => { Beep(700, 100); SB(); Beep(700, 300); };
            }
            public class Eight //8	– – – · ·
            {
                public string Text => "– – – · ·";
                static public Action Sound => () => { Beep(700, 100); SB(); Beep(700, 300); };
            }
            public class Nine //9	– – – – ·
            {
                public string Text => "– – – – ·";
                static public Action Sound => () => { Beep(700, 100); SB(); Beep(700, 300); };
            }
        }
    }
}