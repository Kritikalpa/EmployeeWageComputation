using System;
using System.Collections.Generic;

namespace EmployeeWageComputation.Services
{
    class EmpWageBuilder : InterfaceEmpWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        
        
        private LinkedList<CompanyEmpWage> companyEmpWageList;

        public EmpWageBuilder()
        {
            this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
        }

        public void addCompanyEmpWage(string companyName, int employeeWagePerHour, int maxWorkingDays, int maxWorkingHours)
        {
            this.companyEmpWageList.AddLast(new CompanyEmpWage(companyName, employeeWagePerHour, maxWorkingDays, maxWorkingHours));
            
        }
        public void computeEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage in this.companyEmpWageList)
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

                int totalWage = currentHours * companyEmpWage.employeeWagePerHour;
                companyEmpWage.setTotalEmpWage(totalWage);
                Console.WriteLine(companyEmpWage.getTotalEmpWage());
            }
        }
    }
}
