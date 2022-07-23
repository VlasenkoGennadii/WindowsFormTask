using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ukrposhta.Interfaces;

namespace Ukrposhta.Menu
{
    class EmployeeInfornmation
    {
        DatabaseConnection dataconnection;
        public string comand = string.Empty;
        string special_characters = @"~`!@#$%^&*/()_+Ё!\,<.>/?';][}{|=-";
        List<string> check;
        public string UpdateEmployee(IEmployee employee, int id)
        {
            
            check = new List<string>();
            check.Add(employee.FirstName);
            check.Add(employee.LastName);
            check.Add(employee.MiddleName);
            //check.Add(employee.Address);
            //check.Add(employee.Phone);
            
            foreach (var emp in check)
            {
                foreach (var word in emp)
                {
                    foreach (var item in special_characters)
                    {
                        if (item == word)
                        {
                            return $"Cпециальные символы в строке недопустимы!";
                        }
                    }
                }
            }
            try
            {
                string comand = "Update Employees Set ";
                if (employee.FirstName != "")
                {
                    comand = comand + $"FirstName = '{employee.FirstName}', ";
                    
                }
                if (employee.LastName != "")
                {
                    comand = comand + $"LastName = '{employee.LastName}', ";
                    
                }
                if (employee.MiddleName != "")
                {
                    comand = comand + $"MiddleName = '{employee.MiddleName}', ";
                    
                }
                if (employee.Phone != "")
                {
                    comand = comand + $"Phone = '{employee.Phone}', ";
                }
                if (employee.Address != "")
                {
                    comand = comand + $"Adress = '{employee.Address}', ";
                }
                if (employee.Position != 0)
                {
                    comand = comand + $"PositionId = {employee.Position}, ";
                }
                if (employee.Bonus != "")
                {
                    comand = comand + $"Bonus = '{employee.Bonus}', ";
                }
                comand = comand.Remove(comand.Length - 2, 1);
                comand = comand + $" Where Id = {id}";
                dataconnection = new DatabaseConnection();
                dataconnection.Connection(comand);
            }
            catch
            {
                return "Ошибка при изменении данных";
            }
            return "Данные сотрудника успешно обновлены";

        }
    }
}
