using System;

namespace EmployeeWageComputation.Services
{
    class EmpWageBuilderArray : InterfaceEmpWage
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
        public void computeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                int currentDay = 0, currentHours = 0;
                while (currentDay < this.companyEmpWageArray[i].maxWorkingDays && currentHours < this.companyEmpWageArray[i].maxWorkingHours)
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

                int totalWage = currentHours * this.companyEmpWageArray[i].employeeWagePerHour;
                this.companyEmpWageArray[i].setTotalEmpWage(totalWage);
                Console.WriteLine(this.companyEmpWageArray[i].getTotalEmpWage());
            }
        }
    }
}
