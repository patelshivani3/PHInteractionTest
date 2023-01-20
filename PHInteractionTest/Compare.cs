using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHInteractionTest
{
    public class Compare<T> where T : IComparable
    {
        public T num1, num2, num3;
        public T[] value;

        // Parameterized Constructor
        public Compare(T num1, T num2, T num3)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.num3 = num3;
        }

        //Creating method to find maximum  by using Generic method
        public static T MaxNumber(T num1, T num2, T num3)
        {

            if ((num1.CompareTo(num2) > 0) && (num1.CompareTo(num3) > 0))
            {
                return num1;
            }
            else if ((num2.CompareTo(num1) > 0) && (num2.CompareTo(num3) > 0))
            {
                return num2;
            }
            else
            {
                return num3;
            }
        }
    }
}
