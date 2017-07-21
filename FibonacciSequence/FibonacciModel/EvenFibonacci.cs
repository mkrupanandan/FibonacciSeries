using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciModel
{
    public class EvenFibonacci : Fibonacci
    {
        /// <summary>
        /// The Default Fibonacci Series
        /// </summary>
        private IFibonacci _fibonacci;

        /// <summary>
        /// Default Constructor 
        /// </summary>
        public EvenFibonacci() : base()
        {
        }

        /// <summary>
        /// Constructor to Initialize the Default Fibonacci Series
        /// </summary>
        /// <param name="fibonacci"></param>
        public EvenFibonacci(IFibonacci fibonacci) : base()
        {
            _fibonacci = fibonacci;
        }

        /// <summary>
        /// To get the Even Fibonacci Series by overriding the virtual method
        /// </summary>
        /// <returns>A dictionary of the Even Fibonacci Series</returns>
        public override IDictionary<int, int> getFibonacciSeries()
        {
            IDictionary<int, int> evenFibonacciSeries = new Dictionary<int, int>();
            
            // If the Default Fibonacci Series is not there Load it
            if(_fibonacci == null || _fibonacci.getFibonacciSeries() == null || _fibonacci.getFibonacciSeries().Count <= 0)
            {
                _fibonacci = new Fibonacci();
                _fibonacci.Count = Count;
            }

            if (Count <= 0) return evenFibonacciSeries; // If count is less than or equl to zero return an empty fibonacci series

            // Identify the Even Fibonacci Series from the dictionary
            evenFibonacciSeries = _fibonacci.getFibonacciSeries().Where(x => x.Key % 2 == 0).ToDictionary(y => y.Key, y => y.Value);

            return evenFibonacciSeries;
        }
    }
}
