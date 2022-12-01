// See https://aka.ms/new-console-template for more information
{
    int fullTime = 1, Emp_Rate_Per_Hoyr = 20, empHrs=0, empwage = 120;
    Random randobj = new Random();
    int checkPresent = randobj.Next(0, 2);
    if(checkPresent==fullTime)
    {
        empHrs = 8;
        Console.WriteLine("Employee is present");
    }
    else
    {
        empHrs = 0;
        Console.WriteLine("employee is absent");
    }
    empwage = empHrs * Emp_Rate_Per_Hoyr;
    Console.WriteLine("employee wage:" + empwage);
}