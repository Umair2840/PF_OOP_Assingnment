using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid_decreasing_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 5;
            for (int i = 1; i < size; i++)
            {
                for (int j = size; j > i ; j--)
                {
                    Console.Write("  ");
                }
                Console.Write(i);
                for (int k= 2; k < i + i ;  k++)
                {
                    if(i > 1) Console.Write("  ");

                }
                if (i > 1) Console.WriteLine(i);
                else Console.WriteLine();
            }
            for (int i = 1; i < size; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write("  ");
                }
                Console.Write(i + size );
                for (int k = size; k > i; k--)
                {
                    Console.Write("    ");
                }
                Console.WriteLine(i + size);
            }
        }
            
    }
}
