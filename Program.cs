using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { -4, -7, 0, 2, 5 };
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; ++)
                {
                    if (array[i] > array[j])
                        int p = array[i]; array[i] = array[j]; array[j] = p};
            }
        }
                foreach (int i in nums)
            {
                        Console.Writeline($"{i}");
            }
        }
    }
}
