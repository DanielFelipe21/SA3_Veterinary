using System;
using SA_NOVA.DAL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SA_NOVA
{
    public partial class cadastroDeCliente : Form
    {
        Conexao cnx = new Conexao();
        SqlCommand comm = new SqlCommand();

        public cadastroDeCliente()
        {
            InitializeComponent();
            idClientesTextBox.Enabled = false;
            lbCadastro.ForeColor = Color.FromArgb(22, 108, 191);
            lbCadastro.Font = new Font(lbCadastro.Font.Name, lbCadastro.Font.SizeInPoints, FontStyle.Underline);

            comm.Connection = cnx.conectar();
            comm.CommandText = "SELECT idClientes FROM tbClientes";
            idClientesTextBox.Text = comm.ExecuteScalar().ToString();

            //Limpar campos
            nomeTextBox.Text = "";
            data_nascimentoDateTimePicker.Text = "";
            telefoneTextBox.Text = "";
            celularTextBox.Text = "";
            sexoTextBox.Text = "";
            rgTextBox.Text = "";
            cpfTextBox.Text = "";
            enderecoTextBox.Text = "";
            emailTextBox.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionarImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != "")
            {
                pbImagemCliente.Load(openFileDialog1.FileName);
                lbSize.Visible = false;
            }
        }

        private void lbAnimais_Click(object sender, EventArgs e)
        {
            cadastroDeAnimais frmAnimais = new cadastroDeAnimais();
            frmAnimais.StartPosition = FormStartPosition.CenterScreen;
            frmAnimais.Show();
            this.Hide();
        }

        private void lbCadastro_Click(object sender, EventArgs e)
        {

        }

        private void lbCancelar_Click(object sender, EventArgs e)
        {
            menuDeDecisao frmDecisao = new menuDeDecisao();
            frmDecisao.StartPosition = FormStartPosition.CenterScreen;
            frmDecisao.Show();
            this.Close();
        }

        private void lbConsultas_Click(object sender, EventArgs e)
        {
            cadastroDeConsultas frmConsulta = new cadastroDeConsultas();
            frmConsulta.StartPosition = FormStartPosition.CenterScreen;
            frmConsulta.Show();
            this.Hide();
        }



        private void btnSalvar_Click(object sender, EventArgs e)
        {
            comm.Connection = cnx.conectar();
            comm.CommandText = "INSERT tbClientes VALUES ('"+nomeTextBox.Text+"', '"+data_nascimentoDateTimePicker.Value + "', "+telefoneTextBox.Text + ", "+celularTextBox.Text + ", '"+sexoTextBox.Text + "', '"+rgTextBox.Text + "', '"+cpfTextBox.Text + "', '"+enderecoTextBox.Text + "', '"+emailTextBox.Text + "')";
            comm.ExecuteNonQuery();
            //Limpar dados
            nomeTextBox.Text = "";
            telefoneTextBox.Text = "";
            celularTextBox.Text = "";
            sexoTextBox.Text = "";
            rgTextBox.Text = "";
            cpfTextBox.Text = "";
            enderecoTextBox.Text = "";
            emailTextBox.Text = "";
            MessageBox.Show("Cadastro "+idClientesTextBox+" realizado");
            comm.CommandText = "SELECT idClientes FROM tbClientes";
            idClientesTextBox.Text = comm.ExecuteScalar().ToString();
            comm.Connection.Close();
        }
    }
}
