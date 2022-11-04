using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Inheritance_Example_2_Srk
{
    public class Employe_Bonus: Employee
    {
        public string? empType;     
        public void CheckBonus()
        {             
            int Salary=base.empSalary;

            if (empType == "p" || empType == "P")
            {
                Salary = Salary + 2000;
                Console.WriteLine("Salary With Bonus  :" + Salary);
            }
            else if (empType == "c" || empType == "C")
            {
                Salary = Salary + 1000;
                Console.WriteLine("Salary With Bonus  :" + Salary);
            }
            else if (empType == "i" || empType == "I")
            {
                Salary = Salary + 500;
                Console.WriteLine("Salary With Bonus  :" + Salary);
            }
            else
            {
                Console.WriteLine("Enter Correct Employee Type***");
            }
            Address("Hyderabad");
        }
    }
}
