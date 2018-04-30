using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAmazon
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            //var result =  p.retrieve("jack      ,,,&**   jill's askdf Jack. and and.", new List<string>() { });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.Read();

            string[] inp = new string[4];
            inp[1] = "a1 alps cow bar";
            inp[0] = "mi2 jog mid pet";
            inp[2] = "wz3 34 45";
            inp[3] = "x4 2 56 922";
            var res = p.reorderLines(4, inp);
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }

        private List<string> retrieve(string literatureText, List<string> wordsToExclude)
        {
            List<string> result = new List<string>();

            if (string.IsNullOrEmpty(literatureText))
            {
                return result;
            }

            if (wordsToExclude == null)
            {
                wordsToExclude = new List<string>();
            }

            var hashSet = new HashSet<string>(wordsToExclude, StringComparer.OrdinalIgnoreCase);            

            Dictionary<string, int> wordCount = new Dictionary<string, int>(StringComparer.InvariantCultureIgnoreCase);

            StringBuilder currentWord = new StringBuilder();

            int maxCount = 0, count = 0;

            foreach ( char c in literatureText)
            {
                if (char.IsLetter(c))
                {
                    currentWord.Append(c);
                }
                else
                {
                    if (!string.IsNullOrEmpty(currentWord.ToString()))
                    {
                        count = 0;
                        if (!hashSet.Contains(currentWord.ToString()))
                        {
                            if (wordCount.ContainsKey(currentWord.ToString()))
                            {
                                wordCount.TryGetValue(currentWord.ToString(), out count);

                            }

                            if (count + 1 > maxCount)
                            {
                                maxCount = count + 1;
                            }

                            wordCount[currentWord.ToString()] = count + 1;
                        }
                        currentWord = new StringBuilder();
                    }
                }

            }

            if (char.IsLetter(literatureText[literatureText.Length - 1]) && !string.IsNullOrEmpty(currentWord.ToString()))
            {
                if (!hashSet.Contains(currentWord.ToString()))
                {
                    count = 0;
                    if (wordCount.ContainsKey(currentWord.ToString()))
                    {
                        wordCount.TryGetValue(currentWord.ToString(), out count);

                    }

                    if (count + 1 > maxCount)
                    {
                        maxCount = count + 1;
                    }

                    wordCount[currentWord.ToString()] = count + 1;
                }
            }            

            foreach(var item  in wordCount)
            {
                if (item.Value == maxCount)
                {
                    result.Add(item.Key);
                }
            }

            return result;
        }

        public List<string> reorderLines(int logFileSize, string[] logLines)
        {
            List<string> result = new List<string>();

            if (logLines == null || logFileSize == 0)
            {
                return result;
            }
            if (logFileSize == 1)
            {
                result.Add(logLines[0]);
                return result;
            }

            Dictionary<string, string> dict = new Dictionary<string, string>();
            List<int> list = new List<int>();

            for (int i = 0; i < logFileSize; i++)
            {
                int spaceIndex = logLines[i].IndexOf(' ');
                string id = logLines[i].Substring(0, spaceIndex);
                string rest = logLines[i].Substring(spaceIndex + 1);

                if (char.IsDigit(rest[0]))
                {
                    list.Add(i);
                }
                else
                {
                    dict[id] = rest;
                }
            }

            result = dict.OrderBy(x => x.Value).Select(x => x.Key + " " + x.Value).ToList();

            foreach (int i in list)
            {
                result.Add(logLines[i]);
            }

            return result;
        }
    }
}
