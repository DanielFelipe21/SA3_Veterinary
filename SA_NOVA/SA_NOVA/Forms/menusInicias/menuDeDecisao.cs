using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA_NOVA
{
    public partial class menuDeDecisao : Form
    {
        public menuDeDecisao()
        {
            InitializeComponent();
        }

        private void btnRealizarCadastro_Click(object sender, EventArgs e)
        {
            cadastroDeCliente frmCadastro = new cadastroDeCliente();
            frmCadastro.StartPosition = FormStartPosition.CenterScreen;
            frmCadastro.Show();
            this.Close();
        }

        private void btnAcompanharRegistros_Click(object sender, EventArgs e)
        {
            acompanharCadastros frmAcompanharCadastro = new acompanharCadastros();
            frmAcompanharCadastro.StartPosition = FormStartPosition.CenterScreen;
            frmAcompanharCadastro.Show();
            this.Close();
        }

        private void btnReceitas_Click(object sender, EventArgs e)
        {
            requererReceita frmReceitas = new requererReceita();
            frmReceitas.StartPosition = FormStartPosition.CenterScreen;
            frmReceitas.Show();
            this.Close();
        }

        private void btnCadastrarConsulta_Click(object sender, EventArgs e)
        {
            cadastroDeConsultasAvulso frmConsultaAvulsa = new cadastroDeConsultasAvulso();
            frmConsultaAvulsa.StartPosition = FormStartPosition.CenterScreen;
            frmConsultaAvulsa.Show();
            this.Close();
        }

        private void btnCadastroVeterinario_Click(object sender, EventArgs e)
        {
            cadastroDeVeterinario frmVeterinario = new cadastroDeVeterinario();
            frmVeterinario.StartPosition = FormStartPosition.CenterScreen;
            frmVeterinario.Show();
            this.Close();
        }
    }
}
