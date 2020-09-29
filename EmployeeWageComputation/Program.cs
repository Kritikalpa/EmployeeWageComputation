﻿using EmployeeWageComputation.Services;


namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            
            empWageBuilder.addCompanyEmpWage("Google", 40, 20, 100);
            empWageBuilder.addCompanyEmpWage("Facebook", 30, 15, 75);
            empWageBuilder.computeEmpWage();

            
        }
    }
}
