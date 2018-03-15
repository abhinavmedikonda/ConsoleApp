using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class Matrix
    {
        char[,] array = new char[34,7];

        public void SpiralClockwise()
        {
            Console.WriteLine(this.array.Length);
            Console.WriteLine(this.array.GetLength(0));
            Console.WriteLine(this.array.GetLength(1));
            Console.Read();

            int length = this.array.GetLength(1);
            int width = this.array.GetLength(0);

            int cycles = length < width ? length : width;
            cycles = cycles % 2 == 0 ? cycles / 2 : (cycles / 2) + 1;

            for (int i = 0; i < cycles; i++)
            {
                for (int j = i; j < length - i; j++) { Console.Write(array[i, j]); }
                for (int j = i + 1; j < width - i; j++) { Console.Write(array[j, length - i - 1]); }
                for (int j = length - i - 2; j >= i; j--) { Console.Write(array[width - i - 1, j]); }
                for (int j = width - i - 2; j >= i + 1; j--) { Console.Write(array[j, i]); }
            }

            Console.Read();
        }
    }
}
