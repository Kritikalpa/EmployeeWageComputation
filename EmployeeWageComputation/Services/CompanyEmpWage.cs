using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation.Services
{
    class CompanyEmpWage
    {
        public string companyName;
        public int employeeWagePerHour;
        public int maxWorkingDays;
        public int maxWorkingHours;
        public int totalWage;
        public int avgDailyWage;

        public CompanyEmpWage(string companyName, int employeeWagePerHour, int maxWorkingDays, int maxWorkingHours)
        {
            this.companyName = companyName;
            this.employeeWagePerHour = employeeWagePerHour;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHours = maxWorkingHours;
        }

        public void setTotalEmpWage(int totalWage)
        {
            this.totalWage = totalWage;
        }

        public void setAvgDailyWage(int avgDailyWage)
        {
            this.avgDailyWage = avgDailyWage;
        }

        public string toString()
        {
            return "Total Employee wage for company  " + this.companyName + " is " + this.totalWage + " and average daily wage is " + this.avgDailyWage;
        }
    }
}
