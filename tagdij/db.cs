using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace tagdij
{
    internal class db
    {
        const string server = "SERVER=linsql.verebely.dc;DATABASE=diak36;UID=diak36;PASSWORD=BXGERT;";
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public MySqlDataReader Dr { get => dr; set => dr = value; }

        public db(string querry) 
        {
            con = new MySqlConnection(server);
            cmd = new MySqlCommand(querry, con);
            con.Open();
            dr = cmd.ExecuteReader();
        }
        public void Close()
        {
            con.Close();
        }
        ~db() 
        {
            con.Close();
        }
    }
}
