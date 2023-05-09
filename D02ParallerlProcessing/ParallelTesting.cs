using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02ParallerlProcessing
{
    internal class ParallelTesting
    {
        public void Task1()
        {
            for (int i = 0;i<5; i++)
            {
                Console.WriteLine($"Task1: {i}");

                Thread.Sleep(1000); //sleep for 1 second
            }
        }

        public void Task2()
        {
            for (int i = 10; i < 15; i++)
            {
                Console.WriteLine($"Task2: {i}");

                Thread.Sleep(1000); //sleep for 1 second
            }
        }

    }
}
