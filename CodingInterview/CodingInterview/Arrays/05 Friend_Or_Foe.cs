using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingInterview
{
    class _05_Friend_Or_Foe
    {
        public static void Main05_Friend_Or_Foe(string[] names) {
            var sorted = names.Select(n => n).Where(n => n.Length == 4).ToArray();

            foreach (var item in sorted) {
                Console.WriteLine(item);
            }
        }
    }
}
