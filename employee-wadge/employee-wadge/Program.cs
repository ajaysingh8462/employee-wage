// See https://aka.ms/new-console-template for more information
{
    int fullTime = 1, partTime = 2, Emp_Rate_Per_Hoyr = 20, empHrs=0, empwage = 0;
    Random randobj = new Random();
    int checkPresent = randobj.Next(0, 3);
    if(checkPresent==fullTime)
    {
        empHrs = 8;
        Console.WriteLine("Employee is present");
            empwage = empHrs * Emp_Rate_Per_Hoyr;
    }
        else if(checkPresent == partTime)
        {
        empHrs = 4;
        Console.WriteLine("Employee is Part time");
             empwage = empHrs * Emp_Rate_Per_Hoyr;
        }
    else
    {
        empHrs = 0;
        Console.WriteLine("Employee is absent");
    }
    Console.WriteLine("employee wage:" + empwage);
}