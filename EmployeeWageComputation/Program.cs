using EmployeeWageComputation.Services;


namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeWageBuilderObject google = new EmployeeWageBuilderObject("Google", 40, 20, 100);
            EmployeeWageBuilderObject facebook = new EmployeeWageBuilderObject("Facebook", 30, 15, 75);

            google.computeEmployeeWage();
            facebook.computeEmployeeWage();

            google.toString();
            facebook.toString();
        }
    }
}
