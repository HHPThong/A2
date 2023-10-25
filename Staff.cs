using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2
{
    abstract class Staff // base class
    {
        //defines a public property 
        public int OvertimePay { get; set; }
        public int SalaryDeductions { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public Staff() { } //a default constructor for the "Staff" class        
        public void Input() //Enter the staff member's full name, age, address, and phone number. This is "base.Input()"
        {
            Console.Write("Enter the employee's full name: ");
            FullName = Console.ReadLine();
            Console.Write("Enter the employee's age: ");
            Age = int.Parse(Console.ReadLine());
            Console.Write("Enter the employee's address: ");
            Address = Console.ReadLine();
            Console.Write("Enter the employee's phone number: ");
            PhoneNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter OvertimePay: ");
            OvertimePay = int.Parse(Console.ReadLine());
            Console.Write("Enter Salary Deductions: ");
            SalaryDeductions = int.Parse(Console.ReadLine());
        }
        //The "public abstract void ToString();" method declaration means that the "ToString()" method is a public abstract method. 
        public abstract void ToString();
    }
}
