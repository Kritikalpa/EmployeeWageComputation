using System;

namespace EmployeeWage
{
    class Program
    {

        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int NUM_OF_WORKING_HOURS = 100;


        public static int totalWage = 0, currentDay = 0, currentHours = 0;


        public static void ComputeEmployeeWage()
        {
            while (currentDay < NUM_OF_WORKING_DAYS && currentHours < NUM_OF_WORKING_HOURS)
            {
                int empHours = 0;
                int empWage = 0;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHours = 4;
                        break;

                    case IS_FULL_TIME:
                        empHours = 8;
                        break;

                    default:
                        empHours = 0;
                        break;
                }
                currentHours += empHours;
                currentDay += 1;
                empWage = empHours * EMP_RATE_PER_HOUR;
                totalWage += empWage;
                Console.WriteLine("Day: " + currentDay + ", Hours worked: " + currentHours + ", Wage received: " + empWage + ", Total Wage: " + totalWage);
            }
            Console.WriteLine("Emp Wage : " + totalWage);
        }

        static void Main(string[] args)
        {
            ComputeEmployeeWage();
        }
    }
}
© 2020 GitHub, Inc.