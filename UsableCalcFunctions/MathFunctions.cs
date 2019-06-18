using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsableCalcFunctions
{
    public class MathFunctions
    {
        /// <summary>
        /// This method returns the modulus of the difference of two numbers if the second number 
        /// is greater than the first and the square of the modulus if the first is greater than the second
        /// </summary>
        /// <param name="a">First integer argument</param>
        /// <param name="b">Second integer argument</param>
        /// <returns>Modulus of the difference of the two numbers</returns>
        public static int CompareTwoNumbers(int a, int b)
        {
            if (a>b)
            {
                return (a - b) * 2;   
            }
            return b - a;
        }

        public static int SecondLargest(int[] numArray, out bool exists)
        {
            Array.Sort(numArray);
            exists = false;

            int secondLargest = 0;
            for (int i = 0; i < numArray.Length - 1; i++)
            {
                if (numArray[numArray.Length - (i + 2)] < numArray[numArray.Length - (i + 1)])
                {
                    secondLargest = numArray[numArray.Length - (i + 2)];
                    exists = true;
                    break;
                }
            }
            return secondLargest;
        }

        public static string ValueEqualsIndexValue(int[] numArray)
        {
            string answer = "";
            int a = 0;
            foreach (var c in numArray)
            {
                if (numArray[a] == a + 1)
                {
                    answer += numArray[a] + " ";
                }
                a++;
            }
            return answer;
        }

        public static int FindArraySum(int num)
        {
            int result = 0;
            for (int i = 1; i <= num; i++)
            {
                result += i;
            }
            return result;
        }
    }
}
