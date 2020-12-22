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
    public partial class acompanharConsultas : Form
    {
        public acompanharConsultas()
        {
            InitializeComponent();
            lbConsultasConsultas.ForeColor = Color.FromArgb(22, 108, 191);
            lbConsultasConsultas.Font = new Font(lbConsultasConsultas.Font.Name, lbConsultasConsultas.Font.SizeInPoints, FontStyle.Underline);

            Conexao cnx = new Conexao();
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

        private void acompanharConsultas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdVeterinariaDataSet.tbConsultas'. Você pode movê-la ou removê-la conforme necessário.
            this.tbConsultasTableAdapter.Fill(this.bdVeterinariaDataSet.tbConsultas);

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void lbControleAnimais_Click(object sender, EventArgs e)
        {
            acompanharAnimais frmAcompnharAnimais = new acompanharAnimais();
            frmAcompnharAnimais.StartPosition = FormStartPosition.CenterScreen;
            frmAcompnharAnimais.Show();
            this.Hide();
        }

        private void lbControleCadastros_Click(object sender, EventArgs e)
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
    }
}
