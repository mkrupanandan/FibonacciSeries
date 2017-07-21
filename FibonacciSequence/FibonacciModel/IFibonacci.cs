using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciModel
{
    public interface IFibonacci
    {
        /// <summary>
        /// Property for the first number of the Fibonacci series
        /// </summary>
        int Fibonacci1
        {
            get;
            set;
        }

        /// <summary>
        /// Property for the second number of the Fibonacci series
        /// </summary>
        int Fibonacci2
        {
            get;
            set;
        }

        /// <summary>
        /// Count for the number of Fibonacci series to be calculated
        /// </summary>
        int Count
        {
            get;
            set;
        }

        /// <summary>
        /// Method to get the Fibonacci series
        /// </summary>
        /// <returns></returns>
        IDictionary<int,int> getFibonacciSeries();
    }
}
