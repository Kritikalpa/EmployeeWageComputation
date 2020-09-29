using System;
using System.Collections.Generic;

namespace EmployeeWageComputation.Services
{
    class EmpWageBuilder : InterfaceEmpWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        
        
        private LinkedList<CompanyEmpWage> companyEmpWageList;
        private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;

        public EmpWageBuilder()
        {
            this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
            this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
        }

        public void addCompanyEmpWage(string companyName, int employeeWagePerHour, int maxWorkingDays, int maxWorkingHours)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(companyName, employeeWagePerHour, maxWorkingDays, maxWorkingHours);
            this.companyEmpWageList.AddLast(companyEmpWage);
            this.companyToEmpWageMap.Add(companyName, companyEmpWage);
            
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
                companyEmpWage.setAvgDailyWage(totalWage/20);
                Console.WriteLine(companyEmpWage.toString());
            }
        }
        public int getTotalWage(string company)
        {
            return this.companyToEmpWageMap[company].totalWage;
        }
    }
}
