using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingInterview
{
    class _07_Take_10min_Walk
    {
        public static bool Main07_Take_10min_Walk(string[] walk) {

            //Solution #1 - mine *************************************
            /*
            var n = walk.Select(w => w).Where(w => w == "n").Count();
            var s = walk.Select(w => w).Where(w => w == "s").Count();
            var e = walk.Select(w => w).Where(w => w == "e").Count();
            var w = walk.Select(w => w).Where(w => w == "w").Count();

            return walk.Length == 10 && n == s && e == w;
            */

            //Solution #2 *************************************
            return walk.Count(x => x == "n") == walk.Count(x => x == "s") && walk.Count(x => x == "e") == walk.Count(x => x == "w") && walk.Length == 10;
        }
    }
}
