using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectULER
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32[] IntArray = new int[1000];
            Int32 ArrayCounter = 0;

            for(Int32 counter = 1; counter<1000; counter++)
            {
                if(counter % 3 == 0)
                {
                    IntArray[ArrayCounter] = counter;
                    ArrayCounter++;
                }
                else if(counter % 5 == 0)
                {
                    IntArray[ArrayCounter] = counter;
                    ArrayCounter++;
                }
            }

            Console.WriteLine("The answer is: " + IntArray.Sum());
            Console.ReadLine();
        }
    }
}
