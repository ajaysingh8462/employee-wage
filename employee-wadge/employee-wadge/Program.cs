// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
{
int fulTime = 1;
int partTime = 2;
int Emp_Rate_Per_Hoyr = 20;    
    {
    int empHrs = 0, empwage = 0;
    Random randobj = new Random();
    int checkPresent = randobj.Next(0, 2);
        switch (checkPresent)
        {
            case 1:
                empHrs = 8;
                Console.WriteLine("Employee is present");
                break;
            case 2:
                empHrs = 4;
                Console.WriteLine("Employee is Part time");
                break;
            default:
                empHrs = 0;
                Console.WriteLine("Employee is absent");
                break;
        }
    empwage = empHrs * Emp_Rate_Per_Hoyr;
    Console.WriteLine("employee wage:" + empwage);
    }
}