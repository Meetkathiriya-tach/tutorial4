//1 : The employee list for a company contains employee code, name, designation and basic pay.
//The employee is given a house rent allowance (HRA) of 10% of the basic pay and dearness allowance
//(DA) of 45% of the basic pay. The total pay of the employee is
//calculated as Basic Pay + HRA + DA. Write a class to define the details of the employee.
//Write a constructor to assign the required initial values.
//Add a method to calculate HRA, DA and total pay and print them. Write another class with main method.
//Create objects for three differentemployees and calculate HRA, DA and total pay.
using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial4
{
     class Employee
        {
            public int EmployeeCode { get; set; }
            public string Name { get; set; }
            public string Designation { get; set; }
            public double BasicPay { get; set; }

            public Employee(int code, string name, string designation, double basic)
            {
                EmployeeCode = code;
                Name = name;
                Designation = designation;
                BasicPay = basic;
            }

            public void CalculatePay()
            {
                double HRA = BasicPay * 0.10;
                double DA = BasicPay * 0.45;
                double TotalPay = BasicPay + HRA + DA;

                Console.WriteLine("\n-------- Employee Details --------");
                Console.WriteLine("Employee Code : " + EmployeeCode);
                Console.WriteLine("Name          : " + Name);
                Console.WriteLine("Designation   : " + Designation);
                Console.WriteLine("Basic Pay     : " + BasicPay);
                Console.WriteLine("HRA (10%)     : " + HRA);
                Console.WriteLine("DA (45%)      : " + DA);
                Console.WriteLine("Total Pay     : " + TotalPay);
            }
        }

        public class pri325
        {
            public static void Main()
            {
                Employee e1 = new Employee(101, "Meet", "Dav", 50000);
                Employee e3 = new Employee(103, "khush", "Tester", 30000);

                e1.CalculatePay();
                e3.CalculatePay();
               

                Console.Read();
            }
        }
    }


