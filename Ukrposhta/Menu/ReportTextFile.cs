using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukrposhta.Menu
{
    class ReportTextFile
    {

        DatabaseConnection databaseconnection;
        string comand = string.Empty;
        public string Report()
        {
            databaseconnection = new DatabaseConnection();
            comand = "Select emp.FirstName, emp.LastName, emp.MiddleName, dep.DepartmentName, " +
                     "pos.Position, pos.Salary, /*bon.Grade,*/ Case " +
                     "When emp.Bonus = 'A' Then pos.Salary * 0.2 " +
                     "When emp.Bonus = 'B' Then pos.Salary * 0.3 " +
                     "When emp.Bonus = 'C' Then pos.Salary * 0.4 " +
                     "When emp.Bonus IS NULL Then 0 " +
                     "End as Bonus " +
                     "from Employees emp " +
                     "Join Positions pos " +
                     "On emp.PositionId = pos.Id " +
                     "Join Departments dep " +
                     "On pos.DepartmentId = dep.Id " +
                     "Join Bonus bon " +
                     "On emp.Bonus = bon.Grade " +
                     "Order by dep.DepartmentName";
            databaseconnection.Connection(comand);
            return comand;
        }




    }
}
