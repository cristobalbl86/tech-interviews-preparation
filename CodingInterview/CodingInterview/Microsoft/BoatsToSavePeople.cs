using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Microsoft
{
    class BoatsToSavePeople
    {
		public static void BoatsMain()
		{
			//Console.WriteLine("Hello World");
			//int[] people = new int[]{1,2};
			int[] people = new int[] { 3, 2, 2, 1 };

			//int[] people = new int[]{3,5,3,4};


			int boats = getboats(people, 4);



			Console.WriteLine(boats.ToString());
		}

		//VER #0 - FROM INTERVIEW
		public static int getboats(int[] people, int limit)
		{
			int sum = 0;
			int boats = 0;
			//Array.Sort(people);
			foreach (int person in people)
			{
				sum += person;
				if (sum == limit)
				{
					boats++;
					sum = 0;
				}
				else if (sum >= limit)
				{
					boats++;
					sum = person;
				}
			}


			if (sum > 0)
			{
				boats++;
			}



			return boats;
		}
	}
}

/*
 881. Boats to Save People
Medium
The i-th person has weight people[i], and each boat can carry a maximum weight of limit.

Each boat carries at most 2 people at the same time, provided the sum of the weight of those people is at most limit.

Return the minimum number of boats to carry every given person.  (It is guaranteed each person can be carried by a boat.)


Example 1:

Input: people = [1,2], limit = 3
Output: 1
Explanation: 1 boat (1, 2)
Example 2:

Input: people = [3,2,2,1], limit = 3
Output: 3
Explanation: 3 boats (1, 2), (2) and (3)
Example 3:

Input: people = [3,5,3,4], limit = 5
Output: 4
Explanation: 4 boats (3), (3), (4), (5)
 */


/*
[6:14 PM] Narayana Batchu

Input: people = [1,2], limit = 3
Output: 1
Explanation: 1 boat (1, 2)

[6:15 PM] Narayana Batchu
Input: people = [3,2,2,1], limit = 3
Output: 3
Explanation: 3 boats (1, 2), (2) and (3)

[6:16 PM] Narayana Batchu

Input: people = [3,5,3,4], limit = 5
Output: 4
Explanation: 4 boats (3), (3), (4), (5)


*/

//VERSION #1 - INTERVIEW CASES WORKED
//NEW partial functional solution 12/10/2020
//public static int NumRescueBoats(int[] people, int limit)
//{

//	int boats = 0;
//	int sum = 0;
//	for (int i = 0; i < people.Length; i++)
//	{
//		if (people[i] == limit)
//		{
//			boats++;
//			people[i] = -1;
//			continue;
//		}

//		if (people[i] != -1)
//		{
//			sum = people[i];
//			for (int j = i + 1; j < people.Length; j++)
//			{
//				if (people[j] != -1 && sum + people[j] == limit)
//				{
//					boats++;
//					people[i] = -1;
//					people[j] = -1;
//					break;
//				}
//				else if (people[j] != -1 && sum + people[j] < limit)
//				{
//					sum = sum + people[j];
//					people[i] = -1;
//					people[j] = -1;
//				}
//			}
//			//if(sum > people[i] && people[i] != -1){
//			boats++;
//			sum = 0;
//			//}
//		}

//		if (people[i] != -1)
//		{
//			boats++;
//			people[i] = -1;
//		}
//	}

//	return boats;
//}

//VERSION #2 - WORKS FOR SOME LEETCODE CASES; OTHERS FAILED //12/16/2020
//public int NumRescueBoats(int[] people, int limit)
//{
//	int boats = 0;

//	for (int x = 0; x < people.Length; x++)
//	{
//		if (people[x] == limit)
//		{
//			boats++;
//			people[x] = -1;
//			continue;
//		}

//		if (people[x] != -1 && people[x] < limit)
//		{
//			boats += CheckPeople(people, limit, people[x], x);
//		}
//	}

//	return boats;
//}

//public static int CheckPeople(int[] people, int limit, int sum, int idx)
//{
//	if (idx == people.Length - 1)
//	{
//		return 1;
//	}

//	for (int j = idx + 1; j < people.Length; j++)
//	{
//		if (people[j] == -1)
//			continue;

//		if (people[j] + sum == limit)
//		{
//			people[idx] = -1;
//			people[j] = -1;
//			return 1;
//		}
//		else if (people[j] + sum < limit)
//		{
//			if (CheckPeople(people, limit, people[j] + sum, j) == 1)
//			{
//				people[idx] = -1;
//				people[j] = -1;
//				return 1;
//			}
//		}
//	}

//	//iteration complete but not complement was found
//	//request boat for this single item
//	if (people[idx] != -1)
//	{
//		people[idx] = -1;
//		return 1;
//	}

//	return 0;
//}

//VERSION #3 - WORKED FOR ALL CASES -ST AND END APPROACH- 12/16/2020
//public static int NumRescueBoats(int[] people, int limit)
//{
//	int boats = 0;
//	int st = 0;
//	int ed = people.Length - 1;

//	Array.Sort(people);

//	while (st <= ed)
//	{

//		if (st == ed) {
//			boats++;
//			break;
//		}

//		if (people[st] + people[ed] <= limit)
//		{
//			st++;
//			ed--;
//			boats++;
//			continue;
//		}

//		boats++;
//		ed--;
//	}

//	return boats;
//}

/*
 cases

		int result = NumRescueBoats( new int[] {1,2} ,3); //expected 1
		Console.WriteLine(result.ToString());
		
		result = NumRescueBoats( new int[] {3,2,1,1} ,3); //expected 3
		Console.WriteLine(result.ToString());
		
		result = NumRescueBoats( new int[] {3,5,3,4} ,5); //expected 4
		Console.WriteLine(result.ToString());
		
		result = NumRescueBoats( new int[] {3,2,2,1} ,4); //expected 2
		Console.WriteLine(result.ToString());
		
		//failed in leetcode (worked v2)
		result = NumRescueBoats( new int[] {5,1,4,2} ,6); //expected 2
		Console.WriteLine(result.ToString());
		//failed in leet code (worked v2)
		result = NumRescueBoats( new int[] {3,8,7,1,4} ,9); //expected 3
		Console.WriteLine(result.ToString());
		
		//failed in leet code (12/16)(worked v3)
		result = NumRescueBoats( new int[] {21,40,16,24,30} ,50); //expected 3
		//16,21,24,30,40
		Console.WriteLine(result.ToString());

 */
