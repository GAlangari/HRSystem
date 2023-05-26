﻿using HRSystem.BusinessLayer;
using HRSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem
{
    class Program
    {
        public static readonly CRUD_Operations operation = CRUD_Operations.Instance;
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Console.WriteLine("Write Employee name: ");
            emp.EmployeeName = Console.ReadLine();

            Console.WriteLine("Write Employee salary: ");
            emp.Salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Write Employee Department Id: ");
            emp.Department_id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Write Employee Role Id: ");
            emp.Role_id = Convert.ToInt32(Console.ReadLine());

            var result = operation.AddEmployee(emp);
            if(result > 0)
            {
                Console.WriteLine("Employee inserted");
            }
            else
            {
                Console.WriteLine("Failed to add employee");
            }

            Console.ReadLine();

        }
    }
}
