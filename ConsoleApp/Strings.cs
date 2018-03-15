using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Strings
    {
        static Dictionary<string, string> replaceStringList = new Dictionary<string, string> { { "ab", "cd" }, { "cd", "y" } };
        static string shortestString;

        public string ReplaceTillShortest(string theString)
        {
            shortestString = theString;
            //bool changed = true;
            List<string> sequence = new List<string>();

            //while (changed)
            //{
            //changed = false;
            foreach (string replaceString in replaceStringList.Keys)
            {
                foreach (int index in MatchingIndexesOf(theString, replaceString))
                {
                    StringBuilder modifiedString = new StringBuilder(theString);

                    modifiedString.Remove(index, replaceStringList[replaceString].Length);
                    modifiedString.Insert(index, replaceStringList[replaceString]);
                    if (modifiedString.Length < shortestString.Length)
                    {
                        shortestString = modifiedString.ToString();
                    }
                    //sequence.Add(modifiedString);
                    ReplaceTillShortest(modifiedString.ToString());
                    //changed = true;
                }
            }
            //}

            return shortestString;
        }

        public IEnumerable<int> MatchingIndexesOf(string theString, string theCheckingString)
        {
            for (int index = 0; ; index++)
            {
                index = theString.IndexOf(theCheckingString, index);
                if (index == -1) break;
                yield return index;
            }
        }
    }
}
