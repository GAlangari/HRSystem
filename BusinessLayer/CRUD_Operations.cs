﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSystem.Base_Repository;
using HRSystem.Constants;
using HRSystem.Entities;

namespace HRSystem.BusinessLayer
{
    public class CRUD_Operations : BaseRepository
    {
        public static readonly CRUD_Operations Instance = new CRUD_Operations();

        public int AddEmployee(Employee employee)
        {
            var con = GetConnection();
            var cmd = new SqlCommand(ConstantsQuery.InsertEmployee, con);

            cmd.Parameters.AddWithValue("EmployeeName", employee.EmployeeName);
            cmd.Parameters.AddWithValue("Salary", employee.Salary);
            cmd.Parameters.AddWithValue("Role_id", employee.Role_id);
            cmd.Parameters.AddWithValue("Department_id", employee.Department_id);

            var result = InsertEmployee(cmd, con);
            return result;

        }
        public List<Employee> GetEmployees(int DepartmentId)
        {
            var con = GetConnection();
            var cmd = new SqlCommand(ConstantsQuery.DepartmentEmployees);

            cmd.Parameters.AddWithValue("Department_id", DepartmentId);

            var result = GetDepartmentEmployees(cmd, con);
            return result;
        }
    }
}