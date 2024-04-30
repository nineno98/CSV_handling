using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using MySqlConnector;

namespace CSV_form_app
{
    class DatabaseConnect
    {
        List<Dolgozo> dolgozok;
        private string sqlStatement;
        MySqlConnection dbconn;
        MySqlDataReader reader;

        public DatabaseConnect()
        {
            kapcsolat();
            dolgozok = new List<Dolgozo>();
        }

        private void kapcsolat()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Database = "dolgozok";
            builder.UserID = "root";
            builder.Password = "";

            dbconn = new MySqlConnection(builder.ToString());
        }

        public void InsertDolgozo(Dolgozo dolgozo)
        {
            sqlStatement = $"INSERT INTO `dolgozok`(`nev`, `neme`, `reszleg`, `belepesev`, `ber`) " +
                $"VALUES ('{dolgozo.Nev}','{dolgozo.Neme}','{dolgozo.Reszle}','{dolgozo.Belepesev}','{dolgozo.Ber}')";
            try
            {
                dbconn.Open();

                MySqlCommand command = new MySqlCommand();
                command.Connection = dbconn;
                command.CommandText = sqlStatement;

                command.ExecuteNonQuery();

                dbconn.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
               
            }
        }

        public List<Dolgozo> SelectDolgozok()
        {

            sqlStatement = "SELECT nev, neme, reszleg, belepesev, ber FROM `dolgozok`;";

            try
            {
                dbconn.Open();

                MySqlCommand command = new MySqlCommand();
                command.Connection = dbconn;
                command.CommandText = sqlStatement;

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Dolgozo dolg = new Dolgozo(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4));
                    dolgozok.Add(dolg);
                }

                dbconn.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            return dolgozok;
        }
    }
}
