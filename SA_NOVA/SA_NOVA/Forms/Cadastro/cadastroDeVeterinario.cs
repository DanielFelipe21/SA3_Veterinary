using SA_NOVA.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA_NOVA
{
    public partial class cadastroDeVeterinario : Form
    {

        Conexao cnx = new Conexao();
        SqlCommand comm = new SqlCommand();

        public cadastroDeVeterinario()
        {
            InitializeComponent();
            idVeterinarioTextBox.Enabled = false;

            //Conexão com o Banco
            using (SqlConnection cn = new SqlConnection(cnx.StrCon))
            {
                cnx.conectar();
                var SqlQuery = "SELECT * FROM tbVeterinario";
                using (SqlDataAdapter da = new SqlDataAdapter(SqlQuery, cnx.conectar()))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        gridViewVeterinario.DataSource = dt;
                    }
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            comm.Connection = cnx.conectar();
            comm.CommandText = "INSERT tbVeterinario VALUES ('" + nomeTextBox.Text + "', " + telefoneTextBox.Text + ", '" + data_nascimentoDateTimePicker.Text + "', '" + cpfTextBox.Text + "', '" + enderecoTextBox.Text + "', '" + crmvTextBox.Text + "', '" + emailTextBox.Text + "', '" + dataInsercao.Text + "')";
            comm.ExecuteNonQuery();


            //Limpar dados
            nomeTextBox.Text = "";
            telefoneTextBox.Text = "";
            data_nascimentoDateTimePicker.Text = "";
            cpfTextBox.Text = "";
            enderecoTextBox.Text = "";
            crmvTextBox.Text = "";
            emailTextBox.Text = "";
            dataInsercao.Text = "";
            MessageBox.Show("Cadastro " + idVeterinarioTextBox + " realizado");
            comm.CommandText = "SELECT idVeterinario FROM tbVeterinario";
            idVeterinarioTextBox.Text = comm.ExecuteScalar().ToString();
            comm.Connection.Close();

            //Conexão com o Banco
            using (SqlConnection cn = new SqlConnection(cnx.StrCon))
            {
                cnx.conectar();
                var SqlQuery = "SELECT * FROM tbVeterinario";
                using (SqlDataAdapter da = new SqlDataAdapter(SqlQuery, cnx.conectar()))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        gridViewVeterinario.DataSource = dt;
                    }
                }
            }
        }

        private void cadastroDeVeterinario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdVeterinariaDataSet.tbVeterinario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbVeterinarioTableAdapter.Fill(this.bdVeterinariaDataSet.tbVeterinario);

        }

        private void lbCancelar_Click(object sender, EventArgs e)
        {
            menuDeDecisao frmDecisao = new menuDeDecisao();
            frmDecisao.StartPosition = FormStartPosition.CenterScreen;
            frmDecisao.Show();
            this.Hide();
        }
    }
}
