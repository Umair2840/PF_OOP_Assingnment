using System;

namespace _7._5_Print_Distinct_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            int[] input = { 1, 2, 3, 4, 4, 2, 1, 6, 5, 4, 7, };
            int[] distinct = new int[input.Length];
            int distinctCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                flag = true;
                for (int j = 0; j < distinct.Length; j++)
                {
                    if (input[i] == distinct[j])
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    distinct[distinctCount] = input[i];
                    distinctCount++;
                }
            }
            for (int i = 0; i < distinctCount; i++)
            {
                Console.WriteLine(distinct[i]);
            }


        }
    }
}
