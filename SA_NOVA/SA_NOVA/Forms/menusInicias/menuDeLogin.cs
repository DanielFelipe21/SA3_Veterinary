using SA_NOVA.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA_NOVA
{
    public partial class menuDeLogin : Form
    {
        public menuDeLogin()
        {
            InitializeComponent();
            lbConexao.Text = string.Format("");
            lbErrorLogin.Text = string.Format("");
            lbErrorSenha.Text = string.Format("");
        }

        public string StringConexao;

        private async void btnConectar_ClickAsync(object sender, EventArgs e)
        {
            if (sender == btnConectar)
            {
                Controle controle = new Controle();
                controle.acessar(txtLogin.Text, txtSenha.Text);
                if (txtLogin.Text.Length == 0 && txtSenha.Text.Length == 0)
                {
                    lbErrorLogin.ForeColor = Color.FromArgb(255, 0, 0);
                    lbErrorLogin.Text = string.Format("Este campo não pode ficar vazio!");
                    lbErrorSenha.ForeColor = Color.FromArgb(255, 0, 0);
                    lbErrorSenha.Text = string.Format("Este campo não pode ficar vazio!");
                }
                if (txtLogin.Text.Length == 0)
                {
                    lbErrorLogin.ForeColor = Color.FromArgb(255, 0, 0);
                    lbErrorLogin.Text = string.Format("Este campo não pode ficar vazio!");
                }
                else if (txtSenha.Text.Length == 0)
                {
                    lbErrorSenha.ForeColor = Color.FromArgb(255, 0, 0);
                    lbErrorSenha.Text = string.Format("Este campo não pode ficar vazio!");
                }
                else
                {
                    if (controle.mensagem.Equals(""))
                    {
                        if (controle.cadastrado)
                        {
                            lbConexao.ForeColor = Color.FromArgb(22, 108, 191);
                            lbConexao.Text = string.Format("Conectado com sucesso!");
                            lbConexao.Location = new Point(125, 455);
                            menuDeDecisao frmDecisao = new menuDeDecisao();
                            frmDecisao.StartPosition = FormStartPosition.CenterScreen;
                            await Task.Delay(3000);
                            frmDecisao.Show();
                            this.Hide();
                        }
                        else
                        {
                            lbConexao.ForeColor = Color.FromArgb(255, 0, 0);
                            lbConexao.Text = string.Format("Login ou senha, não encontrados!");
                            lbConexao.Location = new Point(98, 455);
                            await Task.Delay(3000);
                            lbErrorLogin.Text = string.Format("");
                            lbErrorSenha.Text = string.Format("");
                            lbConexao.Text = string.Format("");
                        }
                    }
                    else
                    {
                        MessageBox.Show(controle.mensagem);
                    }
                }
                await Task.Delay(3000);
                lbErrorLogin.Text = string.Format("");
                lbErrorSenha.Text = string.Format("");
            }

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
