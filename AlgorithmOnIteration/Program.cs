using AlgorithmOnIteration;
using BubbleSortType;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 123450;
            string output = "";

            while (input > 0)
            {
                int current = input % 10;
                input /= 10;

                if (current == 0)
                    current = 10;

                output = (char)((char)'A' + (current - 1)) + output;
            }

            Console.WriteLine(output);
            string myList = "aaaaabbccbbbdddde";
            List<List<double>> neweh = new List<List<double>>();
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            int count1 = 1;
            foreach (var s in myList)
            {
                if (keyValuePairs.Select(x => x.Key).LastOrDefault() != s)
                    count1 = 1;
                keyValuePairs[s] = count1;
                count1++;
            }
            string newString = "";
            int count2 = 1;
            int z = 0;
            for (z = 0; z < myList.Length; z++)
            {
                if (z < myList.Length - 1 && myList[z] != myList[z + 1])
                {
                    newString += myList[z];
                    newString += count2;
                    count2 = 0;
                }
                count2++;
            }
            newString += myList[z - 1];
            newString += count2 - 1;
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(newString);


            keyValuePairs.Select(x => x.Key).ToArray();
            var mes = keyValuePairs.Select(x => x.Value).ToArray();
            Console.WriteLine(String.Join("", keyValuePairs));
            Console.WriteLine(String.Join("", mes));
            Console.WriteLine("-----------------------------------");


            string string2 = "A2B5C6D5";

            List<char> newArray = new List<char>();
            for (int i = 0; i < string2.Length; i += 2)
            {
                for (int j = 0; j < string2[i + 1] - '0'; j++)
                {
                    newArray.Add(string2[i]);
                }
            }
            Console.WriteLine(String.Join("", newArray));

            var list = new List<int> { 2, 0, 5, 3, 0, 2 };
            int count = 0;
            List<int> ans = new List<int>();
            foreach (var item in list)
            {
                if (item == 0)
                    count += 1;
                else
                    ans.Add(item);
            }
            for (int i = 0; i < count; i++)
            {
                ans.Add(0);
            }
            Console.WriteLine(String.Join(", ", ans));
            ThreeSumToZeroIteration();
            Console.WriteLine("----------Punch-------------------------");
            PunchSolution();
            TwoSumOptimised();
            var ss = SmallestString.GetSmallestString(5, 73);
            Console.WriteLine("----------Leet-------------------------");
            Console.WriteLine(ss);
            Console.WriteLine("----------Decagon-------------------------");
            string[] inputs = { "/foo/../test/../test/../foo//bar/./baz", "/foo/bar/baz", "foo/bar/baz", "/../../foo/bar/baz", "../../foo/bar/baz" };
            foreach (string input1 in inputs)
            {
                var sss = ShortenPath.ShortenInputPath(input1);
                Console.WriteLine(sss);
            }
            Console.WriteLine("----------Leet-------------------------");
            string[] nn = { "flower", "flow", "flight" };
            string[] nm = { "a", "a", "b" };
            var ssds = LongestCommonPrefix.LongestCommonPrefixMethod(nn);
            Console.WriteLine(ssds);
            Console.WriteLine(ValidParentheses.IsValid());
            Console.WriteLine("----------RemoveDuplicatesMethod-------------------------");
            int[] marks = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int[] mark = new int[] { 1, 1, 2 };
            int length = RemoveDuplicates.RemoveDuplicatesMethod1(marks);
            RemoveDuplicates.FindRoots();
            Console.WriteLine(length);
            /****TEST EMAILS ***/
            List<string> emails = new List<string> { "intadmissions@northampton.ac.uk", "gradapplytranscripts@gsu.edu", "intadmissions@lincoln.ac.uk", "gradtranscripts@ucalgary.ca." };
            Console.WriteLine(String.Join(",", RemoveDuplicates.IsValidEmail(emails)));
            Console.WriteLine("---------HACKER-------");
            List<List<int>> mm = new List<List<int>> {
                new List<int> { -1, - 1, 0, - 9, - 2, - 2 },
                new List<int> { -2, -1, -6, -8, -2, -5 },
                new List<int> { -1, -1, -1 ,-2, -3, -4 },
                new List<int> { -1, -9, -2, -4, -4, -5 },
                new List<int> { -7, -3, -3, -2, -9, -9},
                new List<int> { -1, - 3, - 1, - 2, - 4, - 5 }
            };
            HourGlassSum.HourglassSum(mm);
            Console.WriteLine("---------HACKER2-------");
            List<int> skills = new List<int> { 12, 4, 6, 13, 5, 10 };
            Console.WriteLine(TeamFormation.WaysToFormTeam(skills, 4, 10, 3));
            Console.WriteLine("---------SORT COUNT-------");
            int[] arr = { 4, 3, 1, 2 };
            Console.WriteLine(BubbleSort.MinimumSwaps(arr));
            Console.WriteLine("---------String Manipulation-------");
            string swe = "aaaabbccdde";
            Console.WriteLine(StringManipulation.StringManipulationMethod3(swe));
            Console.WriteLine("---------String Manipulation ANAGRAM-------");
            string a = "bugexikjevtubidpulaelsbcqlupwetzyzdvjphn";
            string b = "lajoipfecfinxjspxmevqxuqyalhrsxcvgsdxxkacspbchrbvvwnvsdtsrdk";
            Console.WriteLine(StringManipulation.makeAnagram(a,b));
            Console.WriteLine("---------Longest Palindrome-------");
            Console.WriteLine(LongestPalindrome.PalindromicSubstring("hellosannasmith"));
            Console.WriteLine("---------Camel Case-------");
            Console.WriteLine(CamelCase.CamelCaseStr("cats AND*Dogs-are Awesome"));
            Console.Read();
        }

        private static void ThreeSumToZeroIteration()
        {
            int[] a = new int[10] { 2, -4, 5, 6, 8, 9, 10, -3, -4, 6 };
            int[,] b = new int[2, 3] { { 2, 3, 4 }, { 4, 5, 6 } }; //multi dimensional array
            int[][] jaggedArray = new int[3][]; //jagged array has fixed rows and varying columns. You have to intialize the rows of a jagged array with its size.


            var answer = ThreeSumIteration.ThreeSumIteration.Count(a);
            if (answer != null)
            {
                Console.WriteLine(String.Join(", ", answer));
                var list = new List<int>() { 1, 0, 5, 3, 4 };
                list.Sort();
                Console.WriteLine(String.Join(", ", list));
            }
        }
        private static void TwoSumOptimised()
        {
            int[] ans = ThreeSumIteration.TwoSumIteration.TwoSumOptimized(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 9);
            Console.WriteLine(string.Join(" ", ans));
        }

        public static void PunchSolution()
        {
            object[] cards = { "Jack", 8, 2, 6, "King", 5, 3, 4, "Queen" };
            var list = cards.ToList();
            Dictionary<int, object> keyValuePairs = new Dictionary<int, object>();
            foreach (object card in cards)
            {
                if ((object)card == "Jack")
                    keyValuePairs.Add(13, card);
                else if ((object)card == "King")
                    keyValuePairs.Add(15, card);
                else if ((object)card == "Queen")
                    keyValuePairs.Add(14, card);
                else
                    keyValuePairs.Add((int)card, card);
            }
            Console.WriteLine(string.Join(", ", keyValuePairs.OrderBy(x => x.Key).Select(x => x.Value)));

            /***Solution 2****/

            List<PunchSolution2> results = new List<PunchSolution2>();
            for (int i = 0; i < cards.Length; i++)
            {
                results.Add(new PunchSolution2(cards[i]));
            }
            Console.WriteLine(string.Join(", ", results.OrderBy(x => x.key).Select(x => x.value)));
            Console.WriteLine("---------END-------");
        }
        public class PunchSolution2
        {
            public PunchSolution2(object value)
            {
                this.key = Sort(value);
                this.value = value;
            }
            public int key { get; set; }
            public object value { get; set; }
            public int Sort(object value)
            {
                if ((object)value == "Jack")
                    return this.key = 13;
                else if ((object)value == "King")
                    return this.key = 15;
                else if ((object)value == "Queen")
                    return this.key = 14;
                else
                    return this.key = (int)value;
            }
        }
    }
}
