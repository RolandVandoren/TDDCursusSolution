using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Palindroom
{
    public class Woord
    {
        public string Text { get; set; }
        public Woord(string woord)
        {
            Text = woord;
        }

        public bool IsPalindroom()
        {
            var omgekeerd = new string(Text.ToArray().Reverse().ToArray());
            return Text == omgekeerd;
        }

        public bool IsPalindroom1()
        {
            return Text == new string(Text.ToArray().Reverse().ToArray());            
        }
        public bool IsPalindroom2()
        {
            for (var i=0; i < Text.Length/2; i++)
            {
                if (Text[i] != Text[Text.Length - 1 - i]) return false;
            }
            return true;
        }
    }
}

