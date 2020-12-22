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
    public partial class acompanharCadastros : Form
    {
        public acompanharCadastros()
        {

            InitializeComponent();
            lbControleCadastros.ForeColor = Color.FromArgb(22, 108, 191);
            lbControleCadastros.Font = new Font(lbControleCadastros.Font.Name, lbControleCadastros.Font.SizeInPoints, FontStyle.Underline);

            //Conexão com o Banco
            Conexao cnx = new Conexao();
            using (SqlConnection cn = new SqlConnection(cnx.StrCon))
            {
                cnx.conectar();
                var SqlQuery = "SELECT * FROM tbClientes";
                using (SqlDataAdapter da = new SqlDataAdapter(SqlQuery, cnx.conectar()))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        gridViewClientes.DataSource = dt;
                    }
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            menuDeDecisao frmDecisao = new menuDeDecisao();
            frmDecisao.StartPosition = FormStartPosition.CenterScreen;
            frmDecisao.Show();
            this.Hide();
        }

        private void lbControleAnimais_Click(object sender, EventArgs e)
        {
            acompanharAnimais frmAcompnharAnimais = new acompanharAnimais();
            frmAcompnharAnimais.StartPosition = FormStartPosition.CenterScreen;
            frmAcompnharAnimais.Show();
            this.Hide();
        }

        private void lbCancelar_Click(object sender, EventArgs e)
        {
            menuDeDecisao frmDecisao = new menuDeDecisao();
            frmDecisao.StartPosition = FormStartPosition.CenterScreen;
            frmDecisao.Show();
            this.Hide();
        }

        private void lbConsultasAnimais_Click(object sender, EventArgs e)
        {
            acompanharConsultas frmConsulta = new acompanharConsultas();
            frmConsulta.StartPosition = FormStartPosition.CenterScreen;
            frmConsulta.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
