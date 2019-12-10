using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TobbbformosPizzaAlkalmazasEgyTabla.model;
using TobbbformosPizzaAlkalmazasEgyTabla.Repository;

namespace TobbbformosPizzaAlkalmazasEgyTabla.repository
{
    class RepositoryFutarDatabase
    {
        private readonly string connectionStringCreate;
        private readonly string connectionString;

        public RepositoryFutarDatabase()
        {
            ConnectionString cs = new ConnectionString();
            connectionStringCreate = cs.getCreateString();
            connectionString = cs.getConnectionString();
        }

        public void createDatabase()
        {
            string query =
                "CREATE DATABASE IF NOT EXISTS csarp " +
                "DEFAULT CHARACTER SET utf8 " +
                "COLLATE utf8_hungarian_ci ";

            MySqlConnection connection =
                new MySqlConnection(connectionStringCreate);
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Adatbázis létrehozás nem sikerült vagy már létezik.");
            }
        }
    }
}
