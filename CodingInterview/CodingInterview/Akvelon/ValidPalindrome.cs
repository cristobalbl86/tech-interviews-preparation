using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Akvelon
{
    class ValidPalindrome
    {
		/*
		Given string, test if it palindrome or not.Consider only characters, not spaces or commas.
		Example:
		These are palindromes:
		"anna"
		"level"
		"Dima Mid"
		"Madam, in Eden - I'm Adam"
		"Cristobal"
		*/

		public static string RemoveInvalidChars(string str)
		{
			StringBuilder sb = new StringBuilder();
			foreach (char c in str) {
				if (char.IsLetter(c))
					sb.Append(c);
			}
			return sb.ToString();
		}

		public static bool IsValidPalindrome(string str)
		{

			string result = string.Empty;

			str = RemoveInvalidChars(str);

			//reverse
			foreach (char c in str.ToLower().ToCharArray())
			{
				result = c + result;
			}

			if (str == result)
			{
				return true;
			}

			return false;

		}

		/*
		str = "Madam, in Eden - I'm Adam"
		"MadaminEdenImAdam"
		"madaminedenimadam"

		result = "madaminedenimadam"


		str = "Cristobal"
		str = "cristobal"


		result = "labotsirc"
		*/

		public static bool IsValidPalindrome2(string str)
		{

			str = RemoveInvalidChars(str.ToLower());
			int st = 0;
			int end = str.Length - 1;

			while (st < end)
			{
				if (str[st] == str[end])
				{
					st++;
					end--;
				}
				else
				{
					return false;
				}
			}

			return true;
		}
		/*
		st 0              end 8
		str = "c r i s t o b a l"

		st 0 1 2
		end 3 2 1
		str = "anna"
		*/

		public static bool IsPalindrome3(string s)
		{
			/*
			 * 03/22/2021 - Udemy
			 T=O(n)
			 S= O(1)
			 */
			if (s == null || s == "")
				return true;

			int st = 0;
			int ed = s.Length - 1;

			s = s.ToUpper();

			while (st < ed)
			{

				while (st < ed && !char.IsLetterOrDigit(s[st])) st++;
				while (st < ed && !char.IsLetterOrDigit(s[ed])) ed--;

				if (s[st] != s[ed]) return false;

				st++;
				ed--;
			}

			return true;

		}
	}
}
