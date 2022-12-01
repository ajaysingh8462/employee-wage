// See https://aka.ms/new-console-template for more information
{
    int fullTime = 1;
    Random randobj = new Random();
    int checkPresent = randobj.Next(0, 2);
    if(checkPresent==fullTime)
    {
        Console.WriteLine("Employee is present");
    }
    else
    {
        Console.WriteLine("employee is absent");
    }
}