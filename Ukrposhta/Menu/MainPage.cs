using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.CheckedListBox;

namespace Ukrposhta.Menu
{
    class MainPage
    {
        DatabaseConnection databaseconnection;
        string comand = string.Empty;
        public string ShowAllEmployees()
        {
            databaseconnection = new DatabaseConnection();
            comand = "Select emp.FirstName, emp.LastName, emp.MiddleName, " +
                "dep.DepartmentName, pos.Position, pos.Salary, " +
                "Case " +
                "When emp.Bonus = 'A' Then pos.Salary * 0.2 " +
                "When emp.Bonus = 'B' Then pos.Salary * 0.3 " +
                "When emp.Bonus = 'C' Then pos.Salary * 0.4 " +
                "When emp.Bonus IS NULL Then pos.Salary " +
                "End as Bonus from Employees emp " +
                "Join Positions pos " +
                "On emp.PositionId = pos.Id Join " +
                "Departments dep On pos.DepartmentId = dep.Id " +
                "Join Bonus bon On emp.Bonus = bon.Grade"; 

            return comand;
        }
        public string ShowEmployeesFromDepartments(CheckedItemCollection selected_departments)
        {
            bool flag = false;
            comand = "Select emp.FirstName, emp.LastName, emp.MiddleName, " +
                "dep.DepartmentName, pos.Position, pos.Salary, /*bon.Grade,*/ " +
                "Case When emp.Bonus = 'A' Then pos.Salary * 0.2 When emp.Bonus = 'B' " +
                "Then pos.Salary * 0.3 When emp.Bonus = 'C' Then pos.Salary * 0.4 " +
                "When emp.Bonus IS NULL Then pos.Salary " +
                "End as Bonus from Employees emp " +
                "Join Positions pos On emp.PositionId = pos.Id " +
                "Join Departments dep On pos.DepartmentId = dep.Id " +
                "Join Bonus bon On emp.Bonus = bon.Grade " +
                "Where dep.DepartmentName = ";
            foreach (var dep in selected_departments)
            {
                if(!flag)
                {
                    comand = comand + $"'{dep}'";
                    flag = true;
                }
                else
                {
                    comand = comand + $"OR dep.DepartmentName = '{dep}'";
                    flag = true;
                }
                
            }
            return comand;
           
        }
    }
}
