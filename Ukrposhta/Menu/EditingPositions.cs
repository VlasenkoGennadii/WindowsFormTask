using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ukrposhta.Interfaces;

namespace Ukrposhta.Menu
{
    class EditingPositions 
    {
        DatabaseConnection dataconnection;
        List<IPositions> positions;
        public string comand = string.Empty;
        SqlDataReader dataReader;
        string special_characters = @"~`!@$%^&*/()_+Ё!\,<>/?';][}{|=-";
        public string ShowAllPositions()
        {
            dataconnection = new DatabaseConnection();
            comand = "Select Position from Positions";
            dataconnection.Connection(comand).Read();
            dataconnection.reader.Close();
            dataconnection.connection.Close();
            return comand;
        }
        public List<IPositions> ShowAllPositions(string comand)
        {
            dataconnection = new DatabaseConnection();
            positions = new List<IPositions>();
            dataReader = dataconnection.Connection(comand);
            while (dataReader.Read())
            {
                positions.Add(new Positions() { Position = (string)dataReader[0]});
            }
            dataReader.Close();
            dataconnection.connection.Close();
            return positions;

        }
        public string AddNewPosition(string position, decimal salary, int departmentid)
        {

            foreach (var word in position)
            {
                foreach (var sym in special_characters)
                {
                    if (word == sym)
                    {
                        return "Название отдела содержит специальные символы. Введите название без них";
                    }
                }
            }
            comand = $"Insert into Positions (Position, Salary, DepartmentId) Values('{position}', {salary}, '{departmentid}')";
            dataconnection.Connection(comand);
            dataconnection.reader.Close();
            dataconnection.connection.Close();
            return "Новая должность успешно добавлена в базу данных";

        }
        public void DeletePosition(string positionname)
        {
            comand = $"Delete Positions Where Position = '{positionname}'";
            dataconnection.Connection(comand);
            dataconnection.reader.Close();
            dataconnection.connection.Close();

        }
        public int GivePositionId(string depname)
        {
            int id;
            comand = $"Select id from Departments Where DepartmentName = '{depname}'";
            id = dataconnection.ConnectionGiveId(comand);
            return id;

        }
        public string UpdatePosition(string newposition, string posname)
        {
            foreach (var word in newposition)
            {
                foreach (var sym in special_characters)
                {
                    if (word == sym)
                    {
                        return "Название содержит специальные символы. Введите название без них";
                    }
                }
            }
            comand = $"Update Positions Set Position = '{newposition}' Where Position = '{posname}'";
            dataconnection.Connection(comand);
            dataconnection.reader.Close();
            dataconnection.connection.Close();
            return "Должность успешно переименовано";


        }
        public void UpdateSalary(decimal newsalary, string position)
        {
            comand = $"Update Positions Set Salary = {newsalary} where Position = '{position}'";
            dataconnection.Connection(comand);
            dataconnection.reader.Close();
            dataconnection.connection.Close();

        }

    }
}
