using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethod
{
    public static class Program
    {
        private static readonly char[] Vovels = new[] {'a', 'e', 'o', 'u', 'i', 'å', 'ö', 'ä'};

        public static bool ÄrKonsonant(this char value)
        {
            return char.IsLetter(value) && !Vovels.Contains(Char.ToLower(value));
        }

        public static string Rövarspråk(this string value) {
            return value.Aggregate("", (ret, c) => ret + c + (c.ÄrKonsonant() ? "o" + c : ""));
        }

        public static void Main() {
            const string text = "Anders Zommarin";
            Console.Out.WriteLine("Antal vokaler = " + text.Count(ÄrKonsonant));
            Console.Out.WriteLine("Translated = " + text.Rövarspråk());
        }
    }
}
