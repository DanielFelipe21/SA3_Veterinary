
namespace SA_NOVA
{
    partial class requererReceita
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idClientesLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label data_nascimentoLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label rgLabel;
            System.Windows.Forms.Label cpfLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label emailLabel;
            this.celularLabel = new System.Windows.Forms.Label();
            this.lbCancelar = new System.Windows.Forms.Label();
            this.lbRequererReceita = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnReceitas = new System.Windows.Forms.Button();
            this.txtTutor = new System.Windows.Forms.TextBox();
            this.tbClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdVeterinariaDataSet = new SA_NOVA.bdVeterinariaDataSet();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dateData = new System.Windows.Forms.DateTimePicker();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtPorte = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtEmissor = new System.Windows.Forms.TextBox();
            this.tableAdapterManager = new SA_NOVA.bdVeterinariaDataSetTableAdapters.TableAdapterManager();
            this.tbClientesTableAdapter = new SA_NOVA.bdVeterinariaDataSetTableAdapters.tbClientesTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExportar = new System.Windows.Forms.Button();
            this.listReceitas = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExcluir = new System.Windows.Forms.Button();
            idClientesLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            data_nascimentoLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            rgLabel = new System.Windows.Forms.Label();
            cpfLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdVeterinariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // idClientesLabel
            // 
            idClientesLabel.AutoSize = true;
            idClientesLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            idClientesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idClientesLabel.Location = new System.Drawing.Point(25, 150);
            idClientesLabel.Name = "idClientesLabel";
            idClientesLabel.Size = new System.Drawing.Size(59, 24);
            idClientesLabel.TabIndex = 31;
            idClientesLabel.Text = "Tutor:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            nomeLabel.Location = new System.Drawing.Point(25, 189);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(67, 24);
            nomeLabel.TabIndex = 33;
            nomeLabel.Text = "Nome:";
            // 
            // data_nascimentoLabel
            // 
            data_nascimentoLabel.AutoSize = true;
            data_nascimentoLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            data_nascimentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            data_nascimentoLabel.Location = new System.Drawing.Point(25, 246);
            data_nascimentoLabel.Name = "data_nascimentoLabel";
            data_nascimentoLabel.Size = new System.Drawing.Size(100, 24);
            data_nascimentoLabel.TabIndex = 35;
            data_nascimentoLabel.Text = "Data Nasc.";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            telefoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            telefoneLabel.Location = new System.Drawing.Point(25, 289);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(62, 24);
            telefoneLabel.TabIndex = 37;
            telefoneLabel.Text = "Idade:";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            sexoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            sexoLabel.Location = new System.Drawing.Point(460, 246);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(59, 24);
            sexoLabel.TabIndex = 41;
            sexoLabel.Text = "Sexo:";
            // 
            // rgLabel
            // 
            rgLabel.AutoSize = true;
            rgLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            rgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            rgLabel.Location = new System.Drawing.Point(25, 349);
            rgLabel.Name = "rgLabel";
            rgLabel.Size = new System.Drawing.Size(84, 24);
            rgLabel.TabIndex = 43;
            rgLabel.Text = "Especie:";
            // 
            // cpfLabel
            // 
            cpfLabel.AutoSize = true;
            cpfLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            cpfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            cpfLabel.Location = new System.Drawing.Point(25, 389);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new System.Drawing.Size(90, 24);
            cpfLabel.TabIndex = 45;
            cpfLabel.Text = "Telefone:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            enderecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            enderecoLabel.Location = new System.Drawing.Point(25, 440);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(50, 24);
            enderecoLabel.TabIndex = 47;
            enderecoLabel.Text = "Obs:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            emailLabel.Location = new System.Drawing.Point(25, 571);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(83, 24);
            emailLabel.TabIndex = 49;
            emailLabel.Text = "Emissor:";
            // 
            // celularLabel
            // 
            this.celularLabel.AutoSize = true;
            this.celularLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.celularLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.celularLabel.Location = new System.Drawing.Point(460, 289);
            this.celularLabel.Name = "celularLabel";
            this.celularLabel.Size = new System.Drawing.Size(59, 24);
            this.celularLabel.TabIndex = 39;
            this.celularLabel.Text = "Porte:";
            // 
            // lbCancelar
            // 
            this.lbCancelar.AutoSize = true;
            this.lbCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbCancelar.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbCancelar.Location = new System.Drawing.Point(165, 26);
            this.lbCancelar.Name = "lbCancelar";
            this.lbCancelar.Size = new System.Drawing.Size(80, 20);
            this.lbCancelar.TabIndex = 59;
            this.lbCancelar.Text = "Cancelar";
            this.lbCancelar.Click += new System.EventHandler(this.lbCancelar_Click);
            // 
            // lbRequererReceita
            // 
            this.lbRequererReceita.AutoSize = true;
            this.lbRequererReceita.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbRequererReceita.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRequererReceita.Location = new System.Drawing.Point(1, 84);
            this.lbRequererReceita.Name = "lbRequererReceita";
            this.lbRequererReceita.Size = new System.Drawing.Size(231, 25);
            this.lbRequererReceita.TabIndex = 56;
            this.lbRequererReceita.Text = "Receituario Veterinario";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvar.Location = new System.Drawing.Point(6, 16);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(132, 41);
            this.btnSalvar.TabIndex = 54;
            this.btnSalvar.Text = "Salvar (F2)";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnReceitas
            // 
            this.btnReceitas.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReceitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceitas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReceitas.Location = new System.Drawing.Point(449, 340);
            this.btnReceitas.Name = "btnReceitas";
            this.btnReceitas.Size = new System.Drawing.Size(439, 33);
            this.btnReceitas.TabIndex = 52;
            this.btnReceitas.Text = "RECEITAS";
            this.btnReceitas.UseVisualStyleBackColor = false;
            // 
            // txtTutor
            // 
            this.txtTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTutor.Location = new System.Drawing.Point(129, 141);
            this.txtTutor.Multiline = true;
            this.txtTutor.Name = "txtTutor";
            this.txtTutor.Size = new System.Drawing.Size(759, 33);
            this.txtTutor.TabIndex = 32;
            // 
            // tbClientesBindingSource
            // 
            this.tbClientesBindingSource.DataMember = "tbClientes";
            this.tbClientesBindingSource.DataSource = this.bdVeterinariaDataSet;
            // 
            // bdVeterinariaDataSet
            // 
            this.bdVeterinariaDataSet.DataSetName = "bdVeterinariaDataSet";
            this.bdVeterinariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtNome.Location = new System.Drawing.Point(129, 180);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(759, 33);
            this.txtNome.TabIndex = 34;
            // 
            // dateData
            // 
            this.dateData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateData.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateData.Location = new System.Drawing.Point(129, 235);
            this.dateData.Margin = new System.Windows.Forms.Padding(1);
            this.dateData.Name = "dateData";
            this.dateData.Size = new System.Drawing.Size(238, 34);
            this.dateData.TabIndex = 36;
            this.dateData.Value = new System.DateTime(2020, 12, 17, 0, 0, 0, 0);
            // 
            // txtIdade
            // 
            this.txtIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtIdade.Location = new System.Drawing.Point(129, 280);
            this.txtIdade.Multiline = true;
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(237, 33);
            this.txtIdade.TabIndex = 38;
            // 
            // txtPorte
            // 
            this.txtPorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtPorte.Location = new System.Drawing.Point(525, 280);
            this.txtPorte.Multiline = true;
            this.txtPorte.Name = "txtPorte";
            this.txtPorte.Size = new System.Drawing.Size(363, 33);
            this.txtPorte.TabIndex = 40;
            // 
            // txtSexo
            // 
            this.txtSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtSexo.Location = new System.Drawing.Point(525, 237);
            this.txtSexo.Multiline = true;
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(363, 33);
            this.txtSexo.TabIndex = 42;
            // 
            // txtEspecie
            // 
            this.txtEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtEspecie.Location = new System.Drawing.Point(129, 340);
            this.txtEspecie.Multiline = true;
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(237, 33);
            this.txtEspecie.TabIndex = 44;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtTelefone.Location = new System.Drawing.Point(129, 380);
            this.txtTelefone.Multiline = true;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(238, 33);
            this.txtTelefone.TabIndex = 46;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtObservacao.Location = new System.Drawing.Point(129, 440);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(238, 98);
            this.txtObservacao.TabIndex = 48;
            // 
            // txtEmissor
            // 
            this.txtEmissor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtEmissor.Location = new System.Drawing.Point(129, 562);
            this.txtEmissor.Multiline = true;
            this.txtEmissor.Name = "txtEmissor";
            this.txtEmissor.Size = new System.Drawing.Size(238, 33);
            this.txtEmissor.TabIndex = 50;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbAnimaisTableAdapter = null;
            this.tableAdapterManager.tbClientesTableAdapter = this.tbClientesTableAdapter;
            this.tableAdapterManager.tbConsultasTableAdapter = null;
            this.tableAdapterManager.tbLoginTableAdapter = null;
            this.tableAdapterManager.tbVeterinarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SA_NOVA.bdVeterinariaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbClientesTableAdapter
            // 
            this.tbClientesTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SA_NOVA.Properties.Resources.utility;
            this.pictureBox1.Location = new System.Drawing.Point(-8, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(988, 648);
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportar.Location = new System.Drawing.Point(713, 570);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(175, 26);
            this.btnExportar.TabIndex = 61;
            this.btnExportar.Text = "Exportar Receita";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // listReceitas
            // 
            this.listReceitas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listReceitas.FullRowSelect = true;
            this.listReceitas.HideSelection = false;
            this.listReceitas.Location = new System.Drawing.Point(449, 367);
            this.listReceitas.Name = "listReceitas";
            this.listReceitas.Size = new System.Drawing.Size(439, 196);
            this.listReceitas.TabIndex = 62;
            this.listReceitas.UseCompatibleStateImageBehavior = false;
            this.listReceitas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tutor";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Idade";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Especie";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Sexo";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Obs";
            this.columnHeader6.Width = 74;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Emissor";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcluir.Location = new System.Drawing.Point(532, 569);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(175, 26);
            this.btnExcluir.TabIndex = 63;
            this.btnExcluir.Text = "Excluir Receita";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // requererReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 621);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.listReceitas);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.lbCancelar);
            this.Controls.Add(this.lbRequererReceita);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnReceitas);
            this.Controls.Add(idClientesLabel);
            this.Controls.Add(this.txtTutor);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(data_nascimentoLabel);
            this.Controls.Add(this.dateData);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.celularLabel);
            this.Controls.Add(this.txtPorte);
            this.Controls.Add(sexoLabel);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(rgLabel);
            this.Controls.Add(this.txtEspecie);
            this.Controls.Add(cpfLabel);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.txtEmissor);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "requererReceita";
            this.Text = "Veterinary Clinic";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.requererReceita_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.tbClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdVeterinariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCancelar;
        private System.Windows.Forms.Label lbRequererReceita;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnReceitas;
        private System.Windows.Forms.TextBox txtTutor;
        private System.Windows.Forms.BindingSource tbClientesBindingSource;
        private bdVeterinariaDataSet bdVeterinariaDataSet;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DateTimePicker dateData;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtPorte;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.TextBox txtEmissor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private bdVeterinariaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private bdVeterinariaDataSetTableAdapters.tbClientesTableAdapter tbClientesTableAdapter;
        private System.Windows.Forms.Label celularLabel;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.ListView listReceitas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnExcluir;
    }
}