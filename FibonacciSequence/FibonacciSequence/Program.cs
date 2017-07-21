using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FibonacciModel;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            // Verify whether the correct number of arguments are passed
            if (args.Length < 1)
            {
                System.Console.WriteLine("Format: FibonacciSequence [Count] [true/false]\n [Count] -- Numbers of the sequence to display\n [true/false] -- Optional -- Whether to display Even Sequence only");
                System.Console.Read();
                return;
            }

            // assign arguments to temperory string variables
            string strCount = args[0];
            string strEvenFlag = args[1];

            // Compute the Count argument
            int i;
            int iCount = (int.TryParse(strCount, out i)) ? i : 0;

            // if Count argument is incorrect print the error message
            if(i <= 0)
            {
                System.Console.WriteLine("Please Enter a [Count] that is greater than 0");
                System.Console.WriteLine("Format: FibonacciSequence [Count] [true/false]\n [Count] -- Numbers of the sequence to display\n [true/false] -- Optional -- Whether to display Even Sequence only");
                System.Console.Read();
                return;
            }

            // Compute the Optional argument
            bool bFlag;
            bool bEvenFlag = (bool.TryParse(strEvenFlag, out bFlag)) ? bFlag : false;

            IFibonacci fibonacci;


            if(bEvenFlag) // If Optional argument is true
            {
                fibonacci = new EvenFibonacci();
                fibonacci.Count = iCount;
            }
            else // If Optional argument is anything other than true
            {
                fibonacci = new Fibonacci();
                fibonacci.Count = iCount;
            }

            // Based upon the argument create and print the appropriate Fibonacci Series
            IDictionary<int, int> fibonacciSeries = fibonacci.getFibonacciSeries();
            int key = 0;
            foreach (int value in fibonacciSeries.Values)
            {
                if (key == (fibonacciSeries.Count - 1)) System.Console.Write("{0}", value);
                else
                    System.Console.Write("{0},", value);

                key++;
            }

            // Wait for key input to Display
            System.Console.Write("\nPlease Enter a Key...");
            System.Console.Read();
        }
    }
}
