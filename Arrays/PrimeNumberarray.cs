/*Listing 5.15 determines whether a num
ber n is prime by checking whether 2, 3, 4, 5, 6, . . . , n/2 is a divisor. If a divisor 
is found, n is not prime. A more efficient approach is to check whether any of the 
prime numbers less than or equal to 2n can divide n evenly. If not, n is prime. 
Rewrite Listing 5.15 to display the first 50 prime numbers using this approach. 
You need to use an array to store the prime numbers, and later use them to check 
whether they are possible divisors for n.*/

using System;

namespace _7._6_Determine_Prime_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] primearray = new int[50];
            int n = 2, i = 0;
            for(i = 0 ; i < primearray.Length;) 
            {
                if (Is_prime(n))
                {  
                    primearray[i] = n;
                    Console.WriteLine(primearray[i]);
                    i++;
                }
                n++;
            }

        }
        public static bool Is_prime(int prime)  // O sir ab ye mt keh di jiye ga ke comment hain to gpt maara ho ga
        {
            if (prime <= 1) return false;          // Handles exception case 
            else if (prime == 2) return true;
            else if (prime % 2 == 0) return false; // Handles even cause
            else
            {
                for (int i = 3; i * i <= prime; i += 2)            // Handles odd case
                {
                    if (prime % i == 0) return false;
                }
                return true;
            }
        }
    }
}













