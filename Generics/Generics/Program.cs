using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // orice Rectangle este si un Shape
            Rectangle rectangle = new Rectangle();
            Shape shape = new Shape();

            IComparable<Rectangle> rectangleComparer = rectangle;
            IComparable<Shape> shapeComparer = shape;


            // I am using a IComparable<Shape> as if it would be a IComparable<Rectangle>
            // IComparable<Shape> '=' IComparable<Rectangle>
            shapeComparer.CompareTo(new Rectangle());





            int[] sortedListOfInt = VariableHelper.SortAsc(10, 9, 8, 7);
            Console.WriteLine($"Array=[{string.Join(",", sortedListOfInt)}]");

            string[] sortedListOfString = VariableHelper.SortAsc("c", "d", "a");
            Console.WriteLine($"Array=[{string.Join(",", sortedListOfString)}]");

            int var1 = 10;
            int var2 = 20;
            VariableHelper.Swap(ref var1, ref var2);
            Console.WriteLine($"{nameof(var1)}={var1}; {nameof(var2)}={var2}");

            string str1 = "test1";
            string str2 = "test2";
            VariableHelper.Swap(ref str1, ref str2);
            Console.WriteLine($"{nameof(str1)}={str1}; {nameof(str2)}={str2}");

            Person p = VariableHelper.CreateVar<Person>();
            p.Print();

            Tuple<int, int> result = DoSomeCalculation();
            int sum = result.Item1 + result.Item2;
            Console.WriteLine($"Sum={sum}, result type={result.GetType().FullName}");

            Tuple<bool, string> otherResult = DoSomeProcessing();
            Console.WriteLine($"Processing result: {otherResult.Item1}, Message='{otherResult.Item2}'");

            Tuple<int, int, int> result3 = DoSomeCalculationWith3Results();
            int sum3 = result3.Item1 + result3.Item2 + result3.Item3;
            Console.WriteLine($"Sum={sum3}");
        }

        private static Tuple<int, int> DoSomeCalculation()
        {
            // Do some calculations before
            return new Tuple<int, int>
            {
                Item1 = 100,
                Item2 = 200
            };
        }

        private static Tuple<bool, string> DoSomeProcessing()
        {
            // Do some calculations before
            return new Tuple<bool, string>
            {
                Item1 = true,
                Item2 = "Processing was successfull"
            };
        }

        private static Tuple<int, int, int> DoSomeCalculationWith3Results()
        {
            // Do some calculations before
            return new Tuple<int, int, int>
            {
                Item1 = 1,
                Item2 = 2,
                Item3 = 3
            };
        }
    }
}
