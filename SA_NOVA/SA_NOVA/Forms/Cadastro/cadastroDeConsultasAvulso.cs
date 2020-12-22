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
    public partial class cadastroDeConsultasAvulso : Form
    {
        Conexao cnx = new Conexao();
        SqlCommand comm = new SqlCommand();

        public cadastroDeConsultasAvulso()
        {

            InitializeComponent();
            idConsultasTextBox.Enabled = false;
            lbConsultasConsultas.ForeColor = Color.FromArgb(22, 108, 191);
            lbConsultasConsultas.Font = new Font(lbConsultasConsultas.Font.Name, lbConsultasConsultas.Font.SizeInPoints, FontStyle.Underline);;

            //Limpar campos

            //Limpar dados
            veterinarioTextBox.Text = "";
            pacienteTextBox.Text = "";
            dataConsulta.Text = "";
            observacaoTextBox.Text = "";
            statusTextBox.Text = "";
            gridViewConsultas.Refresh();

            //Conexão com o Banco
            using (SqlConnection cn = new SqlConnection(cnx.StrCon))
            {
                cnx.conectar();
                var SqlQuery = "SELECT * FROM tbConsultas";
                using (SqlDataAdapter da = new SqlDataAdapter(SqlQuery, cnx.conectar()))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        gridViewConsultas.DataSource = dt;
                    }
                }
            }
        }

        private void btnSalvarForm2_Click_1(object sender, EventArgs e)
        {
            comm.Connection = cnx.conectar();
            comm.CommandText = "INSERT tbConsultas VALUES (" + veterinarioTextBox.Text + ", " + pacienteTextBox.Text + ", '" + dataConsulta.Text + "', '" + observacaoTextBox.Text + "', '" + statusTextBox.Text + "')";
            comm.ExecuteNonQuery();
            comm.CommandText = "SELECT idConsulta FROM tbConsultas";
            idConsultasTextBox.Text = comm.ExecuteScalar().ToString();
            comm.Connection.Close();

            //Limpar dados
            veterinarioTextBox.Text = "";
            pacienteTextBox.Text = "";
            dataConsulta.Text = "";
            observacaoTextBox.Text = "";
            statusTextBox.Text = "";
            MessageBox.Show("Cadastro " + idConsultasTextBox + " realizado");
            gridViewConsultas.Refresh();


            //Atualizar a DataGrid
            using (SqlConnection cn = new SqlConnection(cnx.StrCon))
            {
                cnx.conectar();
                var SqlQuery = "SELECT * FROM tbConsultas";
                using (SqlDataAdapter da = new SqlDataAdapter(SqlQuery, cnx.conectar()))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        gridViewConsultas.DataSource = dt;
                    }
                }
            }
        }

        private void lbCadastroConsultas_Click(object sender, EventArgs e)
        {
            cadastroDeCliente frmCadastro = new cadastroDeCliente();
            frmCadastro.StartPosition = FormStartPosition.CenterScreen;
            frmCadastro.Show();
            this.Hide();
        }

        private void lbAnimaisConsultas_Click(object sender, EventArgs e)
        {
            cadastroDeAnimais frmAnimais = new cadastroDeAnimais();
            frmAnimais.StartPosition = FormStartPosition.CenterScreen;
            frmAnimais.Show();
            this.Hide();
        }

        private void cadastroDeConsultas_Load(object sender, EventArgs e)
        {

        }

        private void lbCancelarForm2_Click(object sender, EventArgs e)
        {
            menuDeDecisao frmDecisao = new menuDeDecisao();
            frmDecisao.StartPosition = FormStartPosition.CenterScreen;
            frmDecisao.Show();
            this.Hide();
        }

        private void lbCancelarForm2_Click_1(object sender, EventArgs e)
        {
            menuDeDecisao frmDecisao = new menuDeDecisao();
            frmDecisao.StartPosition = FormStartPosition.CenterScreen;
            frmDecisao.Show();
            this.Hide();
        }
    }
}
