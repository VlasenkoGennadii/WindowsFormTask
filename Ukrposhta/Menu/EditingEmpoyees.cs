using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ukrposhta.Interfaces;

namespace Ukrposhta.Menu
{
    class EditingEmpoyees
    {
        DatabaseConnection dataconnection;
        public string comand = string.Empty;
        string special_characters = @"~`!@#$%^&*/()_+Ё!\,<.>/?';][}{|=-";
        List<string> check;
        
        public string AddNewEmployee(IEmployee employee) //Добавление сотрудника
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
                        if(item == word)
                        {
                            return $"Cпециальные символы в поле {emp} недопустимы!";
                        }
                    }
                }
            }
           
            
            dataconnection = new DatabaseConnection();
            comand = "Insert into Employees (FirstName, LastName, MiddleName, Phone, Address, PositionId, Bonus)" +
                      $"Values('{employee.FirstName}', '{employee.LastName}', '{employee.MiddleName}', '{employee.Phone}', " +
                      $"'{employee.Address}', '{employee.Position}', '{employee.Bonus}')";
            dataconnection.Connection(comand);
            dataconnection.connection.Close();
            return "Новый сотрудник добавлен в базу данных";

            
        }
        public void DeleteEmployee(int id) //Удаление сотрудника
        {
            comand = $"Delete Employees Where id = {id}";
            dataconnection = new DatabaseConnection();
            dataconnection.Connection(comand);
            dataconnection.connection.Close();
        }
        public void UpdateEmployee(string whatchange, string newvalue, int id) //Редактирование названия полей
        {
            switch(whatchange)
            {
                case "FirstName":
                    {
                        comand = $"Update Employees Set FirstName = {newvalue} Where id = {id}";
                        dataconnection.Connection(comand);
                        dataconnection.connection.Close();
                        break;
                    }
                case "LastName":
                    {
                        comand = $"Update Employees Set LastName = {newvalue} Where id = {id}";
                        dataconnection.Connection(comand);
                        dataconnection.connection.Close();
                        break;
   
                    }
                case "MiddleName":
                    {
                        comand = $"Update Employees Set MiddleName = {newvalue} Where id = {id}";
                        dataconnection.Connection(comand);
                        dataconnection.connection.Close();
                        break;

                    }
                case "Phone":
                    {
                        comand = $"Update Employees Set Phone = {newvalue} Where id = {id}";
                        dataconnection.Connection(comand);
                        dataconnection.connection.Close();
                        break;

                    }
                case "Address":
                    {
                        comand = $"Update Employees Set Address = {newvalue} Where id = {id}";
                        dataconnection.Connection(comand);
                        dataconnection.connection.Close();
                        break;

                        
                    }
                case "Position":
                    {
                        comand = $"Update Employees Set Position = {newvalue} Where id = {id}";
                        dataconnection.Connection(comand);
                        dataconnection.connection.Close();
                        break;
                        
                    }
                case "Bonus":
                    {
                        comand = $"Update Employees Set Bonus = {newvalue} Where id = {id}";
                        dataconnection.Connection(comand);
                        dataconnection.connection.Close();
                        break;
                        
                    }

            }

        } 

    }
}
