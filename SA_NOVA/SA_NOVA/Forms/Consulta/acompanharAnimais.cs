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
    public partial class acompanharAnimais : Form
    {
        public acompanharAnimais()
        {
            InitializeComponent();
            lbControleAnimaisForm2.ForeColor = Color.FromArgb(22, 108, 191);
            lbControleAnimaisForm2.Font = new Font(lbControleAnimaisForm2.Font.Name, lbControleAnimaisForm2.Font.SizeInPoints, FontStyle.Underline);

            //Conexão com o Banco
            Conexao cnx = new Conexao();
            using (SqlConnection cn = new SqlConnection(cnx.StrCon))
            {
                cnx.conectar();
                var SqlQuery = "SELECT * FROM tbAnimais";
                using (SqlDataAdapter da = new SqlDataAdapter(SqlQuery, cnx.conectar()))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        gridViewAnimais.DataSource = dt;
                    }
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            menuDeDecisao frmDecisao = new menuDeDecisao();
            frmDecisao.StartPosition = FormStartPosition.CenterScreen;
            frmDecisao.Show();
            this.Close();
        }

        private void acompanharAnimais_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdVeterinariaDataSet.tbAnimais'. Você pode movê-la ou removê-la conforme necessário.
            this.tbAnimaisTableAdapter.Fill(this.bdVeterinariaDataSet.tbAnimais);

        }

        private void lbControleCadastrosForm2_Click(object sender, EventArgs e)
        {
            acompanharCadastros frmAcompanharCadastro = new acompanharCadastros();
            frmAcompanharCadastro.StartPosition = FormStartPosition.CenterScreen;
            frmAcompanharCadastro.Show();
            this.Hide();
        }

        private void lbCancelar_Click(object sender, EventArgs e)
        {
            menuDeDecisao frmDecisao = new menuDeDecisao();
            frmDecisao.StartPosition = FormStartPosition.CenterScreen;
            frmDecisao.Show();
            this.Hide();
        }

        private void lbControleAnimaisForm2_Click(object sender, EventArgs e)
        {

        }

        private void lbControleConsultasForm2_Click(object sender, EventArgs e)
        {
            acompanharConsultas frmConsulta = new acompanharConsultas();
            frmConsulta.StartPosition = FormStartPosition.CenterScreen;
            frmConsulta.Show();
            this.Hide();
        }
    }
}
