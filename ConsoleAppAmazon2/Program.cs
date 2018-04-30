using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAmazon2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Program p = new Program();
            string [] inp = new string[4];
            inp[1] = "a1 alps cow bar";
            inp[0] = "mi2 jog mid pet";
            inp[2] = "wz3 34 45";

            inp[3] = "x4 2 56 922";
            var res = p.reorderLines(4, inp);
            foreach(var item in res)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
