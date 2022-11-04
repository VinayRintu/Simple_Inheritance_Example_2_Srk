using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Inheritance_Example_2_Srk
{
    public class Employee
    {
        public int empId;
        public string? empName;
        public int empSalary;
        public void Address(string _address)
        {
            string empAdddress=_address;
            Console.WriteLine("Employee Address"+empAdddress);
        }
    }
}
