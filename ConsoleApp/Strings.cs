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

        public int KMPStringMatch(string theString, string theSubString)
        {
            int[] kmpArray = KMPArray(theSubString);
            int j = 0;
            char c;

            for (int i = 0; i < theString.Length; i++)
            {
                c = theString[i];

                if (c == theSubString[j])
                {
                    if (j == theSubString.Length - 1)
                    {
                        return i + 1 - theSubString.Length;
                    }
                    j++;
                }
                else
                {
                    if (j == 0)
                    {
                        continue;
                    }
                    else
                    {
                        j = kmpArray[j - 1];
                        i--;
                    }
                }
            }

            return -1;
        }

        private int[] KMPArray(string theSubString)
        {
            if (string.IsNullOrEmpty(theSubString))
            {
                return null;
            }

            int[] kmpArray = new int[theSubString.Length];
            kmpArray[0] = 0;

            for (int i = 1, j = 0; i < theSubString.Length; i++)
            {
                if (theSubString[i] == theSubString[j])
                {
                    kmpArray[i] = kmpArray[i - 1] + 1;
                    j++;
                }
                else
                {
                    kmpArray[i] = 0;
                    j = 0;
                }
            }

            return kmpArray;
        }
    }
}
