using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ukrposhta.Interfaces;
using static System.Windows.Forms.CheckedListBox;

namespace Ukrposhta
{
    class EditingDepartments
    {
        
        DatabaseConnection dataconnection;
        List<IDepartments> departments;
        public string comand = string.Empty;
        SqlDataReader dataReader;
        string special_characters = @"~`!@#$%^&*/()_+Ё!\,<.>/?';][}{|=-";

        public List<IDepartments> ShowAllDepartments() //Показать все отделы
        {
            dataconnection = new DatabaseConnection();
            departments = new List<IDepartments>();
            comand = "Select DepartmentName from Departments";
            dataReader = dataconnection.Connection(comand);
            while(dataReader.Read())
            {
                departments.Add(new Departments() { DepartmentName = (string)dataReader[0]});

            }
            dataReader.Close();
            dataconnection.connection.Close();
            return departments;
        }
        public string AddNewDepartment(string newdepartment) // Добавить отдел
        {
            comand = "Select DepartmentName from Departments";
            dataconnection = new DatabaseConnection();
            dataReader = dataconnection.Connection(comand);
            foreach (var word in newdepartment)
            {
                foreach (var item in special_characters)
                {
                    if(word == item)
                    {
                        return "В названии содержатся спецсимволы";
                    }
                }
            }

            while (dataReader.Read())
            {
                if (newdepartment == (string)dataReader[0])
                {
                    return "Такое название отдела уже существует! Выберите другое название";
                }
            }
            dataconnection = new DatabaseConnection();
            comand = $"Insert into Departments (DepartmentName) Values('{newdepartment}')";
            dataconnection.Connection(comand);
            return "Отдел успешно добавлен";


        }
        public void DeleteDepartment(string depname) //Удалить отдел
        {
            dataconnection = new DatabaseConnection();
            comand = $"Delete Departments Where DepartmentName = '{depname}'";
            dataconnection.Connection(comand);
            dataconnection.connection.Close();
        }
        public string UpdateDepartments(string newndepame, string whatchange) //Редактировать отдел
        {
            foreach (var word in newndepame)
            {
                foreach (var sym in special_characters)
                {
                    if(word == sym)
                    {
                        return "Использовать спецсимволы в названии недопустимо!";
                    }
                }
            }
            dataconnection = new DatabaseConnection();
            comand = $"Update Departments Set DepartmentName = '{newndepame}' Where DepartmentName = '{whatchange}'";
            dataconnection.Connection(comand);
            dataconnection.connection.Close();
            return "Отдел успешно переименован";
        }
       




    }
}
