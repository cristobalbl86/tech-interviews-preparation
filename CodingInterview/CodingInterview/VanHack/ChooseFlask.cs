using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.VanHack
{
    class ChooseFlask
    {
        public static int chooseFlask(List<int> requirements, int flaskTypes, List<List<int>> markings)
        {

            Hashtable ht = new Hashtable();

            for (int f = 0; f < flaskTypes; f++)
            {
                int waste = -1;
                HashSet<int> hs = new HashSet<int>();

                //Console.WriteLine($"Flask : {f}");

                foreach (var list in markings)
                {

                    if (list[0] != f)
                        continue;

                    //Console.WriteLine($"Marking : {list[1]}");

                    foreach (int r in requirements)
                    {
                        //Console.WriteLine($"Requirement : {r}");
                        if (list[1] >= r && !hs.Contains(r))
                        {
                            hs.Add(r);
                            waste += list[1] - r;
                        }
                    }

                }

                if (waste != -1)
                    ht.Add(f, waste);
            }

            int flask = -1;
            int minwaste = int.MaxValue;
            foreach (DictionaryEntry entry in ht)
            {
                //Console.WriteLine($"Flask {entry.Key} : Waste {entry.Value}");
                if (Convert.ToInt32(entry.Value) <= minwaste)
                {
                    minwaste = (int)entry.Value;
                    flask = (int)entry.Key;
                }
            }
            return flask;
        }

    }
}
