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
    public partial class cadastroDeAnimais : Form
    {

        Conexao cnx = new Conexao();
        SqlCommand comm = new SqlCommand();

        public cadastroDeAnimais()
        {
            InitializeComponent();
            idAnimaisTextBoxAnimais.Enabled = false;
            lbAnimaisAnimais.ForeColor = Color.FromArgb(22, 108, 191);
            lbAnimaisAnimais.Font = new Font(lbAnimaisAnimais.Font.Name, lbAnimaisAnimais.Font.SizeInPoints, FontStyle.Underline);


            comm.Connection = cnx.conectar();
            comm.CommandText = "SELECT idAnimais FROM tbAnimais";
            idAnimaisTextBoxAnimais.Text = comm.ExecuteScalar().ToString();


            //Limpar Dados
            nomeTextBoxAnimais.Text = "";
            data_nascimentoDateTimePicker.Text = "";
            idadeTextBoxAnimais.Text = "";
            sexoTextBoxAnimais.Text = "";
            racaTextBoxAnimais.Text = "";
            pelugemTextBoxAnimais.Text = "";
            porteTextBoxAnimais.Text = "";
            observacaoTextBoxAnimais.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbCadastroForm2_Click(object sender, EventArgs e)
        {
            cadastroDeCliente frmCadastro = new cadastroDeCliente();
            frmCadastro.Show();
            this.Hide();
        }

        private void lbCancelarForm2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbCadastro_Click(object sender, EventArgs e)
        {
            cadastroDeCliente frmCadastro = new cadastroDeCliente();
            frmCadastro.StartPosition = FormStartPosition.CenterScreen;
            frmCadastro.Show();
            this.Hide();
        }

        private void lbCancelar_Click(object sender, EventArgs e)
        {
            menuDeDecisao frmDecisao = new menuDeDecisao();
            frmDecisao.StartPosition = FormStartPosition.CenterScreen;
            frmDecisao.Show();
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            comm.Connection = cnx.conectar();
            comm.CommandText = "INSERT tbAnimais VALUES ('" + nomeTextBoxAnimais.Text + "', '" + data_nascimentoDateTimePicker.Text + "', " + idadeTextBoxAnimais.Text + ", '" + sexoTextBoxAnimais.Text + "', '" + racaTextBoxAnimais.Text + "', '" + pelugemTextBoxAnimais.Text + "', '" + porteTextBoxAnimais.Text + "', '" + observacaoTextBoxAnimais.Text + "')";
            comm.ExecuteNonQuery();


            //Limpar dados
            nomeTextBoxAnimais.Text = "";
            data_nascimentoDateTimePicker.Text = "";
            idadeTextBoxAnimais.Text = "";
            sexoTextBoxAnimais.Text = "";
            racaTextBoxAnimais.Text = "";
            pelugemTextBoxAnimais.Text = "";
            porteTextBoxAnimais.Text = "";
            observacaoTextBoxAnimais.Text = "";
            MessageBox.Show("Cadastro " + idAnimaisTextBoxAnimais + " realizado");
            comm.CommandText = "SELECT idAnimais FROM tbAnimais";
            idAnimaisTextBoxAnimais.Text = comm.ExecuteScalar().ToString();
            comm.Connection.Close();
        }

        private void lbAnimaisAnimais_Click(object sender, EventArgs e)
        {

        }

        private void lbConsultasAnimais_Click(object sender, EventArgs e)
        {
            cadastroDeConsultas frmConsulta = new cadastroDeConsultas();
            frmConsulta.StartPosition = FormStartPosition.CenterScreen;
            frmConsulta.Show();
            this.Hide();
        }
    }
}
