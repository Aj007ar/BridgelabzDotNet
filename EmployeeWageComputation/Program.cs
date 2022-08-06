namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************WELCOME TO EMPLOYEE WAGE COMPUTATION*****************");
            Console.WriteLine("\n***************Employee Attendance***************************");
            UC1EmplyeeAttendance obj = new UC1EmplyeeAttendance();
            obj.CheckAttendance();
            Console.WriteLine("\n*****************Employee Wage*******************************");
            UC2EmployeeWage wage = new UC2EmployeeWage();
            wage.DailyWage();
            Console.WriteLine("\n*****************Part_Time/Full_Time Wage*********************");
            UC3PartTime partTime = new UC3PartTime();
            partTime.PartTimeWage();
            Console.WriteLine("\n*************Epmloyee wage using Switch Case*******************");
            UC4EmpWageSwitch wageCase = new UC4EmpWageSwitch();
            wageCase.Empwage();
            Console.WriteLine("\n**************Total Salary For Month****************************");
            UC5EmpWageMonth totalWage = new UC5EmpWageMonth();
            totalWage.EmpWageMonth();
            Console.WriteLine("\n***************Max Salary using While****************************");
            UC6EmpWageWhile obj1 = new UC6EmpWageWhile();
            obj1.EmpWageTotal();
        }
    }
}