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

        public const string DepartmentDetails = "SELECT A.NUM, B.ID, B.DEPT_NM FROM" +
            "(SELECT COUNT(EmployeeID) NUM FROM Employee WHERE Department_id = @DepartmentID) A, " +
            "(SELECT DepartmentID ID, DepartmentName DEPT_NM FROM Department WHERE DepartmentID = @DepartmentID)B";

        public const string DepartmentEmployees = "SELECT * FROM Employee WHERE Department_id = @Department_id";

        public const string SelectEmployeeRole = "SELECT Role_Id FROM Employee WHERE EmployeeID = @EmployeeID";
        
    }
}
