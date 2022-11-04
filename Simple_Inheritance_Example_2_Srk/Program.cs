// See https://aka.ms/new-console-template for more information
using Simple_Inheritance_Example_2_Srk;


Employe_Bonus objEmpbonus = new Employe_Bonus();

objEmpbonus.empId = 121;
objEmpbonus.empName = "Vinay";
objEmpbonus.empSalary = 12000;

Console.WriteLine("Employee Id  : "+objEmpbonus.empId);
Console.WriteLine("Employee Name  : " + objEmpbonus.empName);
Console.WriteLine("Employee Salary  : " + objEmpbonus.empSalary);

Console.WriteLine("Enter Employee Type : If Employee is Permanent Enter 'P' or'P' ,\n" +
                "If Employee is ContractBase Enter 'c' or 'C' \n" +
                "If Employee is Interns Enter 'i' or 'I'");

objEmpbonus.empType = Console.ReadLine();

objEmpbonus.CheckBonus();

