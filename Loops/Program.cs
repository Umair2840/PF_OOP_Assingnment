using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 8;
            for (int row = 1; row < size; row++)
            {
                int incnum = 1,decnum = 1, num1 = 1,num2 = 2;
                for (int col = size;  col > row; col--)
                {
                    Console.Write("     ");
                }
                while ( num1 <= row)
                {
                    if(incnum.ToString().Length == 1) Console.Write(incnum + "    ");
                    else if(incnum.ToString().Length == 2){ Console.Write(incnum + "   "); }
                    else {  Console.Write(incnum + "   ");}
                        incnum *= 2; num1++;
                }
                decnum = incnum/2;
                while (num2 <= row)
                {
                    decnum /= 2; num2++;
                    if (num2 <= 4) Console.Write(decnum + "    ");
                    else { Console.Write(decnum + "   "); }
                }
                Console.WriteLine();
            }
        }
    }
}

