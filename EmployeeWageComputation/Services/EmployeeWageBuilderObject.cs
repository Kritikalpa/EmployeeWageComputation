using System;

namespace EmployeeWageComputation.Services
{
    class EmployeeWageBuilderObject
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        public string companyName;
        public int employeeWagePerHour;
        public int maxWorkingDays;
        public int maxWorkingHours;
        public int totalWage;

        public EmployeeWageBuilderObject(string companyName, int employeeWagePerHour, int maxWorkingDays, int maxWorkingHours)
        {
            this.companyName = companyName;
            this.employeeWagePerHour = employeeWagePerHour;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHours = maxWorkingHours;
        }

        public void computeEmployeeWage()
        {
            int currentDay = 0, currentHours = 0;
            while (currentDay < this.maxWorkingDays && currentHours < this.maxWorkingHours)
            {
                int empHours = 0;
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
            }

            this.totalWage = currentHours * this.employeeWagePerHour;
            Console.WriteLine("Employee Wage in {0}: {1}", companyName, totalWage);
            
        }

        public void toString()
        {
            Console.WriteLine("Employee Wage in {0}: {1}", companyName, totalWage);
        }
    }
}
