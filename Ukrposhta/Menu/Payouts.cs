using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukrposhta.Menu
{
    class Payouts
    {
        DatabaseConnection dataconnection;
        public string comand = string.Empty;
        public string ShowAllPayouts()  // Вывод общей выплаты из всех отделов
        {
            dataconnection = new DatabaseConnection();
            comand = "Select Sum(pos.Salary + " +
                "Case " +
                "When emp.Bonus = 'A' Then pos.Salary * 0.2 " +
                "When emp.Bonus = 'B' Then pos.Salary * 0.3 " +
                "When emp.Bonus = 'C' Then pos.Salary * 0.4 " +
                "When emp.Bonus IS NULL Then pos.Salary End) from Employees emp " +
                "Join Positions pos " +
                "On emp.PositionId = pos.Id " +
                "Join Departments dep " +
                "On pos.DepartmentId = dep.Id " +
                "Join Bonus bon " +
                "On emp.Bonus = bon.Grade";

            return comand;


        }
        public string ShowDepartmentPayouts(string departmentname)
        {
            dataconnection = new DatabaseConnection();
            comand = "Select Sum(pos.Salary + " +
              "Case " +
              "When emp.Bonus = 'A' Then pos.Salary * 0.2 " +
              "When emp.Bonus = 'B' Then pos.Salary * 0.3 " +
              "When emp.Bonus = 'C' Then pos.Salary * 0.4 " +
              "When emp.Bonus IS NULL Then pos.Salary End) from Employees emp " +
              "Join Positions pos " +
              "On emp.PositionId = pos.Id " +
              "Join Departments dep " +
              "On pos.DepartmentId = dep.Id " +
              "Join Bonus bon " +
              $"On emp.Bonus = bon.Grade";

            if (departmentname != "All Departments")
            {
                comand = comand + $" Where DepartmentName = '{departmentname}'";
            }

            return comand;


        }




    }

}
