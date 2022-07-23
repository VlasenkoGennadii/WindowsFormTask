using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ukrposhta.Interfaces;

namespace Ukrposhta.Menu
{
    class BonusItems
    {
        DatabaseConnection databaseConnection;
        SqlDataReader reader;
        List<IBonus> bonus;
        public List<IBonus> ShowBonus()
        {
            databaseConnection = new DatabaseConnection();
            bonus = new List<IBonus>();
            reader = databaseConnection.Connection("Select Grade from Bonus");
            while (reader.Read())
            {
                bonus.Add(new Bonus() { Grade = (string)reader[0] });
            }
            return bonus;


        }
    }
}
