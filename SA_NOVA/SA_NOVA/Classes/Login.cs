using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA_NOVA.DAL
{
    class Login
    {
        public bool cadastrado = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        public bool verificarLogin(String login, String senha)
        {
            //Verificar se o úsuario esta cadastrado
            cmd.CommandText = "SELECT * FROM tbLogin WHERE login = @login AND senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    cadastrado = true;
                }
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de Dados!";
            }
            return cadastrado;
        }
    }
}
