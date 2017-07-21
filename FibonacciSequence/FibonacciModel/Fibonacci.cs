using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciModel
{
    public class Fibonacci : IFibonacci    
    {
        private int _f1;
        private int _f2;
        private int _count;

        /// <summary>
        /// Property for the first number of the Fibonacci series
        /// </summary>
        public int Fibonacci1
        {
            get { return _f1; }
            set { _f1 = value; }
        }

        /// <summary>
        /// Property for the second number of the Fibonacci series
        /// </summary>
        public int Fibonacci2
        {
            get { return _f2; }
            set { _f2 = value; }
        }

        /// <summary>
        /// Count for the number of Fibonacci series to be calculated
        /// </summary>
        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }
        
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Fibonacci()
        {
            _f1 = 0;
            _f2 = 1;
            _count = 10;
        }

        /// <summary>
        /// To get the Fibonacci Series
        /// </summary>
        /// <returns>A dictionary of the Fibonacci Series</returns>
        public virtual IDictionary<int,int> getFibonacciSeries()
        {
            IDictionary<int, int> fibonacciSeries = new Dictionary<int, int>();

            if (_count <= 0) return fibonacciSeries; // If count is less than or equl to zero return an empty fibonacci series

            int index = 0;

            while(index < _count)
            {
                // initialize the list with the first 2 numbers of the series 
                if (index == 0) fibonacciSeries.Add(index, _f1);
                if (index == 1) fibonacciSeries.Add(index, _f2);

                if(index > 1) fibonacciSeries.Add(index, fibonacciSeries[index - 2] + fibonacciSeries[index - 1]);

                index++;
            }

            return fibonacciSeries;
        }
    }
}
