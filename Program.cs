using HRSystem.BusinessLayer;
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
            //Employee emp = new Employee();
            //Console.WriteLine("Write Employee name: ");
            //emp.EmployeeName = Console.ReadLine();

            //Console.WriteLine("Write Employee salary: ");
            //emp.Salary = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Write Employee Department Id: ");
            //emp.Department_id = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Write Employee Role Id: ");
            //emp.Role_id = Convert.ToInt32(Console.ReadLine());

            //var result = operation.AddEmployee(emp);
            //if(result > 0)
            //{
            //    Console.WriteLine("Employee inserted");
            //}
            //else
            //{
            //    Console.WriteLine("Failed to add employee");
            //}

            //Console.WriteLine("Enter Department ID to display employees: ");
            //var deptId = Convert.ToInt32(Console.ReadLine());
            //List<Employee> employees = operation.GetEmployees(deptId);

            //foreach(var e in employees)
            //{
            //    Console.WriteLine(e.EmployeeID + "\t" + e.EmployeeName + "\t" + e.Salary + "\t" + e.Department_id + "\t" + e.Role_id);
            //}

            Console.WriteLine("Enter Department ID to display details: ");
            var deptId = Convert.ToInt32(Console.ReadLine());
            var Dept = operation.GetDepartment(deptId);

            Console.WriteLine(Dept.DepartmentID + "\t" + Dept.DepartmentName +"\t" + Dept.DepartmentEmployeeNum);

            Console.ReadLine();

        }
    }
}
