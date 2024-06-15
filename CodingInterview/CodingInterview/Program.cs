using System;
using System.Collections;
using System.Collections.Generic;

namespace CodingInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Remove_K_Get_Smallest   
            //_01_Remove_K_Get_Smallest.Main_01_Remove_K_Get_Smallest(3, 473963294);
            #endregion

            #region Count Duplicates String
            //_02_Count_Duplicates_String.Main_02_Count_Duplicates_String("Indivisibilities");
            //_02_Count_Duplicates_String.Main_02_Count_Duplicates_String("aA11");
            //_02_Count_Duplicates_String.Main_02_Count_Duplicates_String("abcde");
            //_02_Count_Duplicates_String.Main_02_Count_Duplicates_String("");
            #endregion

            #region Unique Characters in Strings
            //_03_Unique_String_Characters.Main_03_Unique_String_Characters("Cristobal", "Carolina");
            //_03_Unique_String_Characters.Main_03_Unique_String_Characters("xyabb", "xzca");
            //_03_Unique_String_Characters.Main_03_Unique_String_Characters("Lio", "Ivan");
            #endregion

            #region Highest and Lowest
            //_04_Lowest_And_Higher.Main04_Lowest_And_Higher("47 61 34 95 -14 52 -6"); //95 -14
            #endregion

            #region Friend_Foe
            //_05_Friend_Or_Foe.Main05_Friend_Or_Foe(new string[] { "Cristobal", "Lio", "Ivan", "Caro" });
            #endregion

            #region ShortestWord
            //_06_Shortest_Word.Main06_Shortest_Word("bitcoin take over the world maybe who knows perhaps");
            //_06_Shortest_Word.Main06_Shortest_Word("turns out random test cases are easier than writing out basic ones");
            //_06_Shortest_Word.Main06_Shortest_Word("mama soy paquito no hare travesuras");
            #endregion

            #region 10minWalk
            //Console.WriteLine( _07_Take_10min_Walk.Main07_Take_10min_Walk(new string[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s"}));
            //Console.WriteLine(_07_Take_10min_Walk.Main07_Take_10min_Walk(new string[] { "w", "e", "w", "e", "w", "e", "w", "e", "w", "e", "w", "e" }));
            //Console.WriteLine(_07_Take_10min_Walk.Main07_Take_10min_Walk(new string[] { "w" }));
            //Console.WriteLine(_07_Take_10min_Walk.Main07_Take_10min_Walk(new string[] { "n", "n", "n", "s", "n", "s", "n", "s", "n", "s" }));
            #endregion

            #region SumDigits
            //_15_SumDigits_DigitalRoot.DigitalRoot(347);
            #endregion

            //_33_Valid_Parentheses.IsValid("(]");
            //_34_Generate_Parens.GenerateParenthesis(3);

            //Console.WriteLine(_46_Coin_Change.CoinChange(new int[] {1, 2, 5}, 11));
            //Console.WriteLine(_46_Coin_Change.CoinChange(new int[] { 186, 419, 83, 408 }, 6249));

            //char[] chars = { 'a', 'a', 'b', 'b', 'c', 'c', 'c' };

            //_47_String_Compression.Compress( chars);

            //_58_Last_Stone_Weight.LastStoneWeight(new int[] { 2, 7, 4, 1, 8, 1 });

            //_59_Remove_Vowels_String.removeVowels("leetcodeisacommunityforcoders");

            // _60_Min_Cost_Connect_Sticks.connectSticks(new int[] { 2,4,3 });
            //_60_Min_Cost_Connect_Sticks.connectSticks(new int[] { 1,8,3,5 });

            //CodingInterview.Microsoft.RemoveKDigits.RemoveKdigits("1234567890", 9);

            //int[] nums = { 23, 5, 63, 12, 7, 1, 0, 4, 5, 12 };
            //CodingInterview.Microsoft.RemoveDuplicates_SortedArray.RemoveDuplicates(nums);


            //VanHack.Transactions.totalTransactions(1, "debit");

            //string csv = VanHack.SortCSV.SortCsvColumns("Beth,Charles,Danielle,Adam,Eric\n17945, 10091, 10088, 3907, 10132\n2, 12, 13, 48, 11");

            //string[] chunks = VanHack.Chunks.Chunk("cristobal", 4);

            //VanHack.StemFactory.GetStems();

            Console.WriteLine(Maths.FibonacciNumber.FibMem(5));
            Console.WriteLine(Maths.FibonacciNumber.FibMem(7));
            Console.WriteLine(Maths.FibonacciNumber.FibMem(8));
            Console.WriteLine(Maths.FibonacciNumber.FibMem(50));

            Console.ReadLine();
        }
    }
}
