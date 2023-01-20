using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHInteractionTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nwelcome to generic");
            //Integer
            Console.WriteLine("Enter Any 3 Integer Numbers:");
            int num1Int = Convert.ToInt32(Console.ReadLine());
            int num2Int = Convert.ToInt32(Console.ReadLine());
            int num3Int = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Max Value:" + Compare<int>.MaxNumber(num1Int, num2Int, num3Int));
            Console.WriteLine("-----------------------------------------------------");
            // Float
            Console.WriteLine("Enter Any 3 Float Numbers:");
            float num1Float = Convert.ToSingle(Console.ReadLine());
            float num2Float = Convert.ToSingle(Console.ReadLine());
            float num3Float = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Max Value:" + Compare<float>.MaxNumber(num1Float, num2Float, num3Float));
            Console.WriteLine("-----------------------------------------------------");
            // String
            Console.WriteLine("Enter Any 3 Strings:");
            string num1String = Convert.ToString(Console.ReadLine());
            string num2String = Convert.ToString(Console.ReadLine());
            string num3String = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Max Value:" + Compare<string>.MaxNumber(num1String, num2String, num3String));
            Console.ReadLine();
        }
    }
}
