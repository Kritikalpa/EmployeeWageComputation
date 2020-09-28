using System;

namespace EmployeeWageComputation.Services
{
    class EmpWageBuilderArray
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;

        public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }

        public void addCompanyEmpWage(string companyName, int employeeWagePerHour, int maxWorkingDays, int maxWorkingHours)
        {
            this.companyEmpWageArray[numOfCompany] = new CompanyEmpWage(companyName, employeeWagePerHour, maxWorkingDays, maxWorkingHours);
            numOfCompany++;
        }
        public void employeeTotalWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                this.companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }

        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int currentDay = 0, currentHours = 0;
            while (currentDay < companyEmpWage.maxWorkingDays && currentHours < companyEmpWage.maxWorkingHours)
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

            return currentHours * companyEmpWage.employeeWagePerHour;
            
        }
    }
}
