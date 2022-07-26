using System;
namespace staticConstractor
{
    public class employee
    {
        static employee()
        {
            Console.WriteLine("declear static constructir");
        }
    public static void Salary()
    {
        Console.WriteLine();
        Console.WriteLine("The Salary method");
    }
}
class details
{
    static void Main()
    {
      
        Console.WriteLine();
        employee.Salary();
        Console.ReadLine();
    }
}
}