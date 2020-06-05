using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overridemethos
{
    
    class Program
    {
        static int Power(int input)
        {
            return input * input;
        }
        static int Power(int input, int count)
        {
            int mul = input;
            for (int i = 0; i < count; i++)
                input *= mul;
            return input;
        }

        static int SumAll(int end)
        {
            int sum = 0;
            for (int i = 1; i <= end; i++) sum += i;
            return sum;
        }
        static int SumAll(int start, int end)
        {
            int sum = 0;
            for (int i = start; i <= end; i++) sum += i;
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("int Power(int input): " + Power(5));
            Console.WriteLine("int Power(int input, count): " + Power(5,3));
            Console.WriteLine("int SumAll(int end): " + SumAll(10));
            Console.WriteLine("int SumAll(int start, int end): " + SumAll(5,10));
        }
    }
}
