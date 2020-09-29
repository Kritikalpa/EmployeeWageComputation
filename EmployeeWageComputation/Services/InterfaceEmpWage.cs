using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation.Services
{
    interface InterfaceEmpWage
    {
        void addCompanyEmpWage(string companyName, int employeeWagePerHour, int maxWorkingDays, int maxWorkingHours);

        void computeEmpWage();

        int getTotalWage(string company);
    }
}
