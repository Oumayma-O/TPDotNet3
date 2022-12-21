using System.Collections.Generic;
using System.Data.SQLite;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;

namespace TP33.Models
{
    public class Personal_info
    {
        public List<Person> GetAllPerson()
        {
            List<Person> list = new List<Person>();
            SQLiteConnection con = new SQLiteConnection("DataSource=database.db"); 
            con.Open();
            string query = "SELECT * FROM personal_info";
            SQLiteCommand Sqlite_com = con.CreateCommand();
            Sqlite_com.CommandText = query;
            SQLiteDataReader Reader = Sqlite_com.ExecuteReader();
            while (Reader.Read())
            {
                int id =(int)Reader["ID"];
                string first_name = (string)Reader["first_name"];
                string last_name = (string)Reader["last_name"];
                string email = (string)Reader["Email"];
                //string DateBirth = (string)Reader["DateBirth"];
              
                string image = (string)Reader["image"];
                string country = (string)Reader["Country"];
                list.Add(new Person(id, first_name, last_name, email, image, country));

            }
            con.Close();

            return list;



        }

        public Person? GetPerson(int id)
        {
            
            List<Person> list = GetAllPerson();
            foreach(Person p in list)
            {
                if(p.Id == id)
                {
                    return p;
                }

            }
            return null; 



        }

    }
}
