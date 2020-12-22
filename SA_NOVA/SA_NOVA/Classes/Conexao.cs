using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA_NOVA.DAL
{
    public class Conexao
    {


        public SqlConnection con = new SqlConnection();

        public string StrCon
        {
            get { return con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\danie\Documents\bdVeterinaria.mdf;Integrated Security=True;Connect Timeout=30"; }
        }

        public Conexao()
        {
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\danie\Documents\bdVeterinaria.mdf;Integrated Security=True;Connect Timeout=30";
        }



        public SqlConnection conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
