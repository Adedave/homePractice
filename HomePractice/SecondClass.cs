using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HomePractice
{
    class SecondClass
    {
        public void Method1()
        {
            List<int> vs = new List<int>();

            Thread thread = new Thread(() => {
                for (int i = 0; i < 1000; i++)
                {
                    Console.WriteLine($"xy{i}");
                }
            });
            thread.Start();
            thread.Abort();

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"y{i}");
            }
        }
    }

    public class Student
    {

    }
}
