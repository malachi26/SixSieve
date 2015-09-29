using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PrimesList
{
    class Program
    {

        static void Main(string[] args)
        {
            var upperLimit = 9999;
            var primes = new List<long>();
            primes.Add(2);
            for (long i = 3; i < upperLimit; i += 2)
            {
                primes.Add(i);
            }

            foreach(var prime in primes.ToArray())
            {
                for (var j = primes.Count - 1; j >= 0; j--)
                {
                    if (primes[j] == prime) continue;
                    if (primes[j] % prime == 0)
                        primes.RemoveAt(j);
                }
            }
            primes.ForEach(Console.WriteLine);

            Console.WriteLine("The Last Prime is " + primes[primes.Count - 1]);
            Console.WriteLine("what are you waiting for? Exit the program!");
            Console.ReadLine();
        }
    }
}
