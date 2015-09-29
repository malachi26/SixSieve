using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixSieve
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = 1000;
            
            //boolean[] isPrime = new boolean [maxNumber];
            bool[] isPrime = new bool[maxNumber];


            isPrime[2] = true;
            isPrime[3] = true;
            
            for (int i = 5, j = 7; i < maxNumber; i+=6, j+=6) {
                isPrime[i] = true;
            
                if (j < maxNumber)       
                    isPrime[j] = true;
            }
            
            
            for (int i = 5; i*i <= maxNumber; i+=2) {
                if (isPrime[i]) {
                    for (int j = i, z = i*i; j*i <= maxNumber; ) {
                        if(j*i == z && z < maxNumber/2) {
                            while (true){
                                if (z <= maxNumber) {
                                    isPrime[z] = false; 
                                    z = z+(i*i*2);
                                }
                                else{
                                    j+=2; break;
                                }
                            }
                        } else {
                            isPrime[j*i] = false;
                            j+=2;
                            while (!isPrime[j]) {
                                j+=2;
                            }
                        }
                    }
                }   
            }
            Console.WriteLine("Done");
            
            for (int i = 0; i < maxNumber; i++) {
                if (isPrime[i])
                    Console.WriteLine(i + " ");
                
            }
        }
    }
}
