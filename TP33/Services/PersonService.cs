using System.Data.SQLite;
using TP33.Models;

namespace TP33.Services
{
    public class PersonService
    {

        public List<Person> GetAllPerson()
        {
            var allPersons = new List<Person>();

            SQLiteConnection sqlite_conn = new SQLiteConnection("DataSource=database.db"); ;
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd;
            string query = "SELECT * FROM personal_info";
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = query;
            sqlite_cmd.ExecuteNonQuery();
            SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                int id = sqlite_datareader.GetInt16(0);
                string first_name = sqlite_datareader.GetString(1);
                string last_name = sqlite_datareader.GetString(2);
                string email = sqlite_datareader.GetString(3);
                string date = sqlite_datareader.GetString(4);
                string country = sqlite_datareader.GetString(6);

                allPersons.Add( new Person(id,first_name ,last_name ,email  ,date,country));

            }

            sqlite_conn.Close();


            return allPersons;
        }
        public Person GetPersonById(int idDto)
        {
            

            SQLiteConnection sqlite_conn = new SQLiteConnection("DataSource=database.db"); ;
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd;
            string query = "SELECT * FROM personal_info";
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = query;
            sqlite_cmd.ExecuteNonQuery();
            SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader();
            var Personne = new Person();
            while (sqlite_datareader.Read())
            {
                int id = sqlite_datareader.GetInt16(0);
                if(id != idDto ) continue;
                string first_name = sqlite_datareader.GetString(1);
                string last_name = sqlite_datareader.GetString(2);
                string email = sqlite_datareader.GetString(3);
                string date = sqlite_datareader.GetString(4);
                string country = sqlite_datareader.GetString(6);

                Personne = new Person(id, first_name, last_name, email, date, country);
                break;
            }


            sqlite_conn.Close();


            return Personne;
        }



    }
}
