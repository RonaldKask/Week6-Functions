using System;
using System.ComponentModel.Design.Serialization;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            ParamsSum(50, 50);
            ParamsWord("Apple");

        }

        public static void ParamsSum(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }

        public static void ParamsWord(string c)
        {
            Console.WriteLine(c);
        }

        //public static void ParamsArray(int[] = {"pear", "grapes", "oranges", "banana", })
        //{
        //
        //}
            
    }
}
