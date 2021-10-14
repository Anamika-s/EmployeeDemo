 using System;
  class Employee
    {
        readonly int id;
        string name;
        static string dept;
        int salary;
        public const string companyName="UST" ;
        // Default Constructor
          public Employee() {} 
        // Parameterized Constructor
        public Employee(string name)
        {
            this.name = name;
            Console.WriteLine("Enter ID");
            id= Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter Department");
            dept = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            salary = Convert.ToInt16(Console.ReadLine());
        }
        // Parameterized Constructor
        public Employee(int id, string name)
        {
            this.name = name;
             
            this.id= id;
            Console.WriteLine("Enter Department");
            dept = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            salary = Convert.ToInt16(Console.ReadLine());
        }
        // Fully Parameterized Constructor
        public Employee(int id, string name, string dept, int salary)
        {
            this.name = name;
             
            this.id= id;
             
            this.dept = dept;
            
            this.salary = salary;
            }
   // Static Constructor , Parameterless
            static Employee()
            {
                dept="HR";
            }
        public  void GetDetails()
        {
            Console.WriteLine("Enter ID");
            id= Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
// Console.WriteLine("Enter Department");
// dept = Console.ReadLine();
Console.WriteLine("Enter Salary");
salary = Convert.ToInt16(Console.ReadLine());
}
public void DisplayDetails()
 {
Console.WriteLine("ID is " + id);
Console.WriteLine("Name is " + name);
// Console.WriteLine("Department is " + dept);
Console.WriteLine("Salary is " + salary);
 }
 public static void DepartmentDetails()
 {
   dept="HR";
   // name="";
     Console.WriteLine("Dept is " +  dept);
 }
  }