using System;
using System.Collections.Generic;
using System.Linq;
using UsableCalcFunctions;

namespace HomePractice
{
  
    public class GFG
    {
        public static void Main()
        {
            Console.WriteLine(MathFunctions.CompareTwoNumbers(10,50));
            Console.ReadLine();
            var secondClass = new SecondClass();
            secondClass.Method1();
            Console.ReadLine();
            List<string> companies = new List<string>() { "Consolidated Messenger LTD",
                   "Coho Winery", "Wide World Importers", "Graphic Design Institute", "Adventure Works LTD",
                   "Humongous Insurance", "Woodgrove Bank LTD", "Margie's Travel", "Northwind Traders",
                   "Blue Yonder Airlines", "Trey Research LTD", "Fourth Coffee LTD" };

            List<Company> companies2 = new List<Company> {
                                new Company{Name = "Davo", Employees = new string[] {"Chidinma","" } },
                                new Company{Name = "", Employees = new string[] {"","" } },
                                new Company{Name = "", Employees = new string[] {"","" } },
                                new Company{Name = "", Employees = new string[] {"","" } },
                                new Company{Name = "", Employees = new string[] {"","" } }
            };


            var query = (from c in companies
                         where c.EndsWith("LTD")
                         orderby c descending
                         select new Company()
                         {
                             Name = c.ToUpper(),
                             Employees = new string[1] { "" }
                         }).ToList();

            var subQuery = from company in companies2
                               // where c.Name != "Airtel"
                           where (from f in company.Employees
                                  where f == "Chidinma"
                                  select f).Any()
                           select company.Name;

            foreach (var item in subQuery)
            {
                Console.WriteLine(item);
            }
            Array.ForEach(query.ToArray(), c => Console.WriteLine(c.Name));

            Console.WriteLine("=======================");


            int i = 1;
            //bool itExists = false;
            
            Console.WriteLine("Input the number of Test Cases");
            Int32.TryParse(Console.ReadLine(), out int noOfTestCases);

            //int[] answersArray = new int[noOfTestCases];
            string[] valueIndexAnswer = new string[noOfTestCases];
        nextCase:
            //answersArray[i - 1] = SecondLargest(Input(i), out itExists);
            //valueIndexAnswer[i - 1] = ValueEqualsIndexValue(Input(i));
            i++;
            if (i <= noOfTestCases)
            {
                goto nextCase;
            }

            //PrintOutSecondLargest(answersArray);
            PrintOutValueIndex(valueIndexAnswer);
            Console.ReadLine();
        }

        public static int[] Input(int i)
        {
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
            return numbers;
        }
        public static void PrintOutSecondLargest(int[] answersArray)
        {
            foreach (int c in answersArray)
            {
                Console.WriteLine(c);
            }
        }

        public static void PrintOutValueIndex(string[] answerArray)
        {
            foreach (var c in answerArray)
            {
                if (c == "")
                {
                    Console.WriteLine("Not Found!");
                }
                else
                {
                    Console.WriteLine(c);
                }
            }
        }

        
    }

    public class Company
    {
        public string Name { get; set; }

        public string[] Employees { get; set; }
    }
}
