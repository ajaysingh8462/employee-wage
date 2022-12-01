// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
{
int fulTime = 1;
int partTime = 2;
int Emp_Rate_Per_Hoyr = 20;
int Max_Working_Day = 20;
int maxWorkingHourInMonth = 100;
    {
    int empHrs = 0, totalEmpHrs =0, empwage = 0, totalWorkingDays =0 ,totalErning = 0;
    while(totalEmpHrs <= maxWorkingHourInMonth && totalWorkingDays < Max_Working_Day)
        {
            totalWorkingDays++;
            Random randobj = new Random();
            int checkPresent = randobj.Next(0, 3);
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
            maxWorkingHourInMonth += totalEmpHrs;
            totalErning += empwage;
            Console.WriteLine("employee wage:" + empwage);
        }
        Console.WriteLine("total working hour:" + maxWorkingHourInMonth);
        Console.WriteLine("total employee wage:" + totalErning);
    }
}