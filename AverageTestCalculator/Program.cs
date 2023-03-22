using System;

namespace AverageTestCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The average is: " + AverageCalculator());
        }

        /// <summary>
        /// Returns a Double.
        /// Ask's for User Input from the console and calculates the average of up to 20 inputs.
        /// It will stop once the user inputs "-1" or reaches 20 inputs.
        /// </summary>
        /// <returns></returns>
        public static double AverageCalculator()
        {
            double sum = 0;
            int students = 0;
            string input = "";

            while (!input.Equals("-1"))
            {
                Console.WriteLine("Please Enter -1 to stop and get the average.");
                Console.WriteLine($"The number of students entered is {students}");
                Console.WriteLine("Enter Student Grade:");
                input = Console.ReadLine();
                if(!Int32.TryParse(input, out int num))
                {
                    Console.WriteLine($"{input} is not a number");
                    continue;
                }
                if (num != -1)
                {
                    if (students >= 0 && students < 20)
                    {
                        sum += num;
                        students++;
                    }
                    else
                    {
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("Only 20 Students allowed");
                        input = "-1";
                    }
                }

            }
            if (students > 0)
            {
                return (double)sum/(double)students;
            }
            else
            {
                return 0;
            }
        }
    }
}
