using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA_NOVA
{
    public partial class requererReceita : Form
    {
        public requererReceita()
        {
            InitializeComponent();
            lbRequererReceita.ForeColor = Color.FromArgb(22, 108, 191);
            lbRequererReceita.Font = new Font(lbRequererReceita.Font.Name, lbRequererReceita.Font.SizeInPoints, FontStyle.Underline);
        }

        private void requererReceita_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.F2:
                btnSalvar_Click(sender, e);
                break;
            }
        }

        private void lbCancelar_Click(object sender, EventArgs e)
        {
            menuDeDecisao frmDecisao = new menuDeDecisao();
            frmDecisao.StartPosition = FormStartPosition.CenterScreen;
            frmDecisao.Show();
            this.Hide();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ListViewItem varItem = new ListViewItem(new string[] { txtTutor.Text,
                                                                txtNome.Text,
                                                                txtIdade.Text,
                                                                txtEspecie.Text,
                                                                txtSexo.Text,
                                                                txtObservacao.Text,
                                                                txtEmissor.Text
                                                               });
            listReceitas.Items.Add(varItem);
            listReceitas.Items[listReceitas.Items.Count - 1].EnsureVisible();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Texto |* .txt",
                InitialDirectory = @"c:\dados\txt",
                FileName = "receitas" + ".txt",
                ValidateNames = true
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                    {
                        foreach (ListViewItem item in listReceitas.Items)
                        {
                            tw.WriteLineAsync(" -----------------------------------------------");
                            tw.WriteLineAsync($"| Informações:");
                            tw.WriteLineAsync($"| Tutor: {item.SubItems[0].Text}");
                            tw.WriteLineAsync($"| Nome do Animal: {item.SubItems[1].Text}");
                            tw.WriteLineAsync($"| Idade: {item.SubItems[2].Text}");
                            tw.WriteLineAsync($"| Especie: {item.SubItems[3].Text}");
                            tw.WriteLineAsync($"| Sexo: {item.SubItems[4].Text}");
                            tw.WriteLineAsync($"| Observação: {item.SubItems[5].Text}");
                            tw.WriteLineAsync($"| Orgão Emissor: {item.SubItems[6].Text}");
                            tw.WriteLineAsync(" -----------------------------------------------");
                        }
                        MessageBox.Show("Seus dados foram exportados para o formato texto com sucesso");
                    }
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (listReceitas.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Selecione uma receita.");
            }
            else
            {
                string TEXT_Confirmacao = "Você realmente deseja excluir está receita?";
                if (MessageBox.Show(string.Format("Deseja remover a(s) {0} receitas selecionadas?", listReceitas.SelectedIndices.Count), TEXT_Confirmacao, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                MessageBox.Show("A receita selecionada, foi apagada!");
                for (int i = listReceitas.SelectedItems.Count - 1; i >= 0; i--)
                {
                    ListViewItem li = listReceitas.SelectedItems[i];
                    listReceitas.Items.Remove(li);
                }
            }
        }
    }
}
