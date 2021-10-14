using System;

namespace EmployeeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
          Employee employee1 = new Employee();
          employee1.GetDetails();
          employee1.DisplayDetails();

          Employee employee2 = new  Employee("Raakesh");
        //   employee2.GetDetails();
          employee2.DisplayDetails();

          Employee employee3 = new  Employee(10, "Athira");
        //   employee3.GetDetails();
          employee3.DisplayDetails();
          Employee employee4 = new  Employee(11, "Neeraj","IT",25000);
          employee4.DisplayDetails();

        }
    }
}
