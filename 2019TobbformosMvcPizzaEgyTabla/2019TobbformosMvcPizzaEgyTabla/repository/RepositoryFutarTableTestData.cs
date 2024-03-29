﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TobbbformosPizzaAlkalmazasEgyTabla.Repository;

namespace TobbbformosPizzaAlkalmazasEgyTabla.repository
{
    partial class RepositoryFutarDatabaseTable
    {
        public void fillFutarokWithTestDataFromSQLCommand()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();

                string query =
                    "INSERT INTO `pfutar` (`fazon`, `fnev`, `ftel`) VALUES " +
                            " (1, 'István', '+36705468974'), " +
                            " (2, 'Anna', '+36202368874'), " +
                            " (3, 'Éva', '+36705468974'), " +
                            " (4, 'Ildikó', '+36305423974'), " +
                            " (5, 'József', '+36702108974'); ";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Tesztadatok feltöltése sikertelen.");
            }
        }
    }
}
