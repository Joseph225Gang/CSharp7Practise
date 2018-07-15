using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 8;
            int num2 = 0b1000;
            Console.WriteLine($"Num1 = {num1}");
            Console.WriteLine($"num2 = {num2}");

            int num11 = 1000000;
            // 當千份號使用
            int num22 = 1_000_000;
            // 隨便使用
            int num3 = 1_00_00_00;
            int num4 = 1__000___000;
            Console.WriteLine(num11);
            Console.WriteLine(num22);
            Console.WriteLine(num3);
            Console.WriteLine(num4);

            setValue(out int height);
            Console.WriteLine(height);

            var body = GetHeightAndWeight();
            Console.WriteLine($"Height = {body.Item1}");
            Console.WriteLine($"Weight = {body.Item2}");

            function1();
            Console.ReadKey();
        }

        static Tuple<int, int> GetHeightAndWeight()
        {
            var returnVal = new Tuple<int, int>(172, 80);
            return returnVal;
        }


        private static void setValue(out int height)
        {
            height = 20;
        }

        static void function1()
        {
            // local function
            int function2()
            {
                return 1;
            }
            var result = function2();
            Console.WriteLine($"Call func2() = {result}");
            // Call func2() = 0
        }

    }
}
