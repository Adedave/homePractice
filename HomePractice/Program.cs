using System;

namespace HomePractice
{
  
    public class GFG
    {
        static public void Main()
        {
            int i = 1;
            //int secondLargestNo = 0;
            bool itExists = false;
            Console.WriteLine("Input the number of Test Cases");
            Int32.TryParse(Console.ReadLine(), out int noOfTestCases);

            int[] answersArray = new int[noOfTestCases];
            int[,] num = { { 2, 2, 3 }, { 3, 2, 4 } };
            //PrintArray(num);

        nextCase:
            Console.WriteLine("Test Case {0}", i);
            Console.Write("Input the size of the array:");
            Int32.TryParse(Console.ReadLine(), out int sizeOfArray);

            int[] numbers = new int[sizeOfArray];

            for (int a = 0; a < sizeOfArray; a++)
            {
                Console.WriteLine("Input the integer {0} of the array", a + 1);

                Int32.TryParse(Console.ReadLine(), out numbers[a]);
            }
            Console.WriteLine();
            answersArray[i - 1] = SecondLargest(numbers, out itExists);
            
            i++;
            if (i <= noOfTestCases)
            {
                goto nextCase;
            }

            foreach (int c in answersArray)
            {
                Console.WriteLine(c);
            }

            Console.ReadLine();
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
        
    }
}
