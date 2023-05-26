using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.Constants
{
    class ConstantsQuery
    {
        public const string InsertEmployee = "INSERT INTO Employee (EmployeeName, Salary, Role_id, Department_id)" +
            "VALUES (@EmployeeName, @Salary, @Role_id, @Department_id)";
        public const string DepartmentDetails = "SELECT * FROM Department WHERE DepartmentID = @Id";
        public const string DepartmentEmployees = "SELECT * FROM Employee WHERE Department_id = @Department_id";
        public const string DepartmentEmployeesNum = "SELECT COUNT(EmployeeID) FROM Employee WHERE Department_id = @Department_id";
        
    }
}
