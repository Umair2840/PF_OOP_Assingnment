using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _seond_max_in_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int secondmax = 0;

            int[] array = { 8, 2, 3, 7 };

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    secondmax = max;
                    max = array[i];
                }
                else if (array[i] > secondmax)
                {
                    secondmax = array[i];
                }
            }

            Console.WriteLine("Max: " + max);
            Console.WriteLine("Second Max: " + secondmax);

        }
    }
}
