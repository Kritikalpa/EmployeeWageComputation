using System;

namespace EmployeeWage
{
    class Program
    {

        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;


        public static void ComputeEmployeeWage(String companyName, int employeeWagePerHour, int maxWorkingDays, int maxWorkingHours)
        {
            int totalWage = 0, currentDay = 0, currentHours = 0;
            while (currentDay < maxWorkingDays && currentHours < maxWorkingHours)
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
                empWage = empHours * employeeWagePerHour;
                totalWage += empWage;

            }
            Console.WriteLine("Employee Wage in {0}: {1}", companyName, totalWage);
        }

        static void Main(string[] args)
        {
            ComputeEmployeeWage("Google", 40, 20, 100);
            ComputeEmployeeWage("Facebook", 30, 15, 75);
        }
    }
}