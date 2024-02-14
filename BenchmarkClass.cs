using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;


namespace BenchmarkExample
{
    [MemoryDiagnoser(false)]
    public class BenchmarkClass
    {
        // Method one
        [Benchmark]
        public int SumUsingChar()
        {
            int number = 123;
            string strNumber = number.ToString();
            int sum = 0;
            foreach (char i in strNumber)
            {
                sum += (int)i - '0';
            }
            return sum;
        }

        // Method Two
        [Benchmark]
        public int SumUsingCalc()
        {
            int number = 123;
            int sum = 0;
            while (number > 0)
            {
                sum = (number % 10);
                number /= 10;
            }
            return sum;
        }
    }
}
