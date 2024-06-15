using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;

namespace CodingInterview
{
    /*
     *Runtime: 272 ms, faster than 51.63% of C# online submissions for Reorder Data in Log Files.
        Memory Usage: 34.5 MB, less than 42.09% of C# online submissions for Reorder Data in Log Files. 
     */
    class _12_Reorder_Logs_OA
    {
        public static string[] ReorderLogFiles(string[] logs)
        {
            List<string> dig = new List<string>();
            List<string> lett = new List<string>();
            string[] result = new string[logs.Length];
            double iv = 0;

            //Verify and separate type of logs
            foreach (string log in logs)
            {
                string val = log.Substring(log.IndexOf(" ") + 1);
                val = val.Replace(" ", "");
                if (double.TryParse(val, out iv))
                { //check if is a number
                    dig.Add(log);
                }
                else
                    lett.Add(log);
            }

            //Sort letters log, first by log text and then by log id
            lett = lett.Select(l => l)
                .OrderBy(l => l.Substring(l.IndexOf(" ") + 1))
                .ThenBy(l => l.Substring(0, l.IndexOf(" "))).ToList();

            //build the final array
            int didx = 0;
            for (int x = 0; x < logs.Length; x++)
            {
                if (x < lett.Count())
                    result[x] = lett[x];
                else
                {
                    result[x] = dig[didx];
                    didx++;
                }
            }

            return result;
        }
        public string[] ReorderLogFiles2(string[] logs)
        {
            /**
             T= O(n)
             S= O(n)
             */
            //SortedList<string, string> letters = new SortedList<string, string>();

            List<string> letters = new List<string>();
            List<string> digits = new List<string>();
            List<string> result = new List<string>();


            foreach (string log in logs)
            {

                string logval = log.Substring(log.IndexOf(' ') + 1, 1);

                if (char.IsDigit(char.Parse(logval)))
                {
                    digits.Add(log);
                }
                else
                {

                    letters.Add(
                        //log.Substring(log.IndexOf(' ') + 1)
                        //    + log.Substring(0, log.IndexOf(' ')),
                        log
                    );
                }
            }

            letters = letters
                .OrderBy(l => l.Substring(l.IndexOf(' ') + 1))
                .ThenBy(l => l.Substring(0, l.IndexOf(' ')))
                .Select(l => l).ToList();

            result.AddRange(letters);
            result.AddRange(digits);
            /*
            foreach(var ll in letters){
                result.Add(ll);            
            }

            foreach(var dl in digits){
                result.Add(dl);
            }
            */

            return result.ToArray();
        }
    }
}
/*
 937. Reorder Data in Log Files
Easy

You are given an array of logs. Each log is a space-delimited string of words, where the first word is the identifier.

There are two types of logs:

Letter-logs: All words (except the identifier) consist of lowercase English letters.
Digit-logs: All words (except the identifier) consist of digits.
Reorder these logs so that:

The letter-logs come before all digit-logs.
The letter-logs are sorted lexicographically by their contents. If their contents are the same, then sort them lexicographically by their identifiers.
The digit-logs maintain their relative ordering.
Return the final order of the logs.

 

Example 1:

Input: logs = ["dig1 8 1 5 1","let1 art can","dig2 3 6","let2 own kit dig","let3 art zero"]
Output: ["let1 art can","let3 art zero","let2 own kit dig","dig1 8 1 5 1","dig2 3 6"]
Explanation:
The letter-log contents are all different, so their ordering is "art can", "art zero", "own kit dig".
The digit-logs have a relative order of "dig1 8 1 5 1", "dig2 3 6".
Example 2:

Input: logs = ["a1 9 2 3 1","g1 act car","zo4 4 7","ab1 off key dog","a8 act zoo"]
Output: ["g1 act car","a8 act zoo","ab1 off key dog","a1 9 2 3 1","zo4 4 7"]
 

Constraints:

1 <= logs.length <= 100
3 <= logs[i].length <= 100
All the tokens of logs[i] are separated by a single space.
logs[i] is guaranteed to have an identifier and at least one word after the identifier.
 */