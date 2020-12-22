
namespace SA_NOVA
{
    partial class cadastroDeCliente
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
            System.Windows.Forms.Label celularLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label rgLabel;
            System.Windows.Forms.Label cpfLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label emailLabel;
            this.bdVeterinariaDataSet = new SA_NOVA.bdVeterinariaDataSet();
            this.tbClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbClientesTableAdapter = new SA_NOVA.bdVeterinariaDataSetTableAdapters.tbClientesTableAdapter();
            this.tableAdapterManager = new SA_NOVA.bdVeterinariaDataSetTableAdapters.TableAdapterManager();
            this.idClientesTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.data_nascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.celularTextBox = new System.Windows.Forms.TextBox();
            this.rgTextBox = new System.Windows.Forms.TextBox();
            this.cpfTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.btnAdicionarImagem = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.sexoTextBox = new System.Windows.Forms.TextBox();
            this.lbSize = new System.Windows.Forms.Label();
            this.lbCadastro = new System.Windows.Forms.Label();
            this.lbAnimais = new System.Windows.Forms.Label();
            this.lbConsultas = new System.Windows.Forms.Label();
            this.lbCancelar = new System.Windows.Forms.Label();
            this.pbImagemCliente = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            idClientesLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            data_nascimentoLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            rgLabel = new System.Windows.Forms.Label();
            cpfLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdVeterinariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemCliente)).BeginInit();
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
            idClientesLabel.Size = new System.Drawing.Size(76, 24);
            idClientesLabel.TabIndex = 1;
            idClientesLabel.Text = "Código:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            nomeLabel.Location = new System.Drawing.Point(25, 189);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(67, 24);
            nomeLabel.TabIndex = 3;
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
            data_nascimentoLabel.TabIndex = 5;
            data_nascimentoLabel.Text = "Data Nasc.";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            telefoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            telefoneLabel.Location = new System.Drawing.Point(25, 289);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(90, 24);
            telefoneLabel.TabIndex = 7;
            telefoneLabel.Text = "Telefone:";
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            celularLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            celularLabel.Location = new System.Drawing.Point(445, 289);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(74, 24);
            celularLabel.TabIndex = 9;
            celularLabel.Text = "Celular:";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            sexoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            sexoLabel.Location = new System.Drawing.Point(460, 246);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(59, 24);
            sexoLabel.TabIndex = 11;
            sexoLabel.Text = "Sexo:";
            // 
            // rgLabel
            // 
            rgLabel.AutoSize = true;
            rgLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            rgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            rgLabel.Location = new System.Drawing.Point(25, 349);
            rgLabel.Name = "rgLabel";
            rgLabel.Size = new System.Drawing.Size(42, 24);
            rgLabel.TabIndex = 13;
            rgLabel.Text = "RG:";
            // 
            // cpfLabel
            // 
            cpfLabel.AutoSize = true;
            cpfLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            cpfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            cpfLabel.Location = new System.Drawing.Point(25, 389);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new System.Drawing.Size(52, 24);
            cpfLabel.TabIndex = 15;
            cpfLabel.Text = "CPF:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            enderecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            enderecoLabel.Location = new System.Drawing.Point(25, 440);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(99, 24);
            enderecoLabel.TabIndex = 17;
            enderecoLabel.Text = "Endereço:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            emailLabel.Location = new System.Drawing.Point(25, 571);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(68, 24);
            emailLabel.TabIndex = 19;
            emailLabel.Text = "E-mail:";
            // 
            // bdVeterinariaDataSet
            // 
            this.bdVeterinariaDataSet.DataSetName = "bdVeterinariaDataSet";
            this.bdVeterinariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbClientesBindingSource
            // 
            this.tbClientesBindingSource.DataMember = "tbClientes";
            this.tbClientesBindingSource.DataSource = this.bdVeterinariaDataSet;
            // 
            // tbClientesTableAdapter
            // 
            this.tbClientesTableAdapter.ClearBeforeFill = true;
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
            // idClientesTextBox
            // 
            this.idClientesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClientesBindingSource, "idClientes", true));
            this.idClientesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idClientesTextBox.Location = new System.Drawing.Point(129, 141);
            this.idClientesTextBox.Multiline = true;
            this.idClientesTextBox.Name = "idClientesTextBox";
            this.idClientesTextBox.Size = new System.Drawing.Size(146, 33);
            this.idClientesTextBox.TabIndex = 2;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClientesBindingSource, "nome", true));
            this.nomeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.nomeTextBox.Location = new System.Drawing.Point(129, 180);
            this.nomeTextBox.Multiline = true;
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(585, 33);
            this.nomeTextBox.TabIndex = 4;
            // 
            // data_nascimentoDateTimePicker
            // 
            this.data_nascimentoDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_nascimentoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_nascimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data_nascimentoDateTimePicker.Location = new System.Drawing.Point(129, 235);
            this.data_nascimentoDateTimePicker.Margin = new System.Windows.Forms.Padding(1);
            this.data_nascimentoDateTimePicker.Name = "data_nascimentoDateTimePicker";
            this.data_nascimentoDateTimePicker.Size = new System.Drawing.Size(238, 34);
            this.data_nascimentoDateTimePicker.TabIndex = 6;
            this.data_nascimentoDateTimePicker.Value = new System.DateTime(2020, 12, 17, 0, 0, 0, 0);
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClientesBindingSource, "telefone", true));
            this.telefoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.telefoneTextBox.Location = new System.Drawing.Point(129, 280);
            this.telefoneTextBox.Multiline = true;
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(237, 33);
            this.telefoneTextBox.TabIndex = 8;
            // 
            // celularTextBox
            // 
            this.celularTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClientesBindingSource, "celular", true));
            this.celularTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.celularTextBox.Location = new System.Drawing.Point(525, 280);
            this.celularTextBox.Multiline = true;
            this.celularTextBox.Name = "celularTextBox";
            this.celularTextBox.Size = new System.Drawing.Size(189, 33);
            this.celularTextBox.TabIndex = 10;
            // 
            // rgTextBox
            // 
            this.rgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClientesBindingSource, "rg", true));
            this.rgTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.rgTextBox.Location = new System.Drawing.Point(129, 340);
            this.rgTextBox.Multiline = true;
            this.rgTextBox.Name = "rgTextBox";
            this.rgTextBox.Size = new System.Drawing.Size(237, 33);
            this.rgTextBox.TabIndex = 14;
            // 
            // cpfTextBox
            // 
            this.cpfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClientesBindingSource, "cpf", true));
            this.cpfTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cpfTextBox.Location = new System.Drawing.Point(129, 380);
            this.cpfTextBox.Multiline = true;
            this.cpfTextBox.Name = "cpfTextBox";
            this.cpfTextBox.Size = new System.Drawing.Size(238, 33);
            this.cpfTextBox.TabIndex = 16;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClientesBindingSource, "endereco", true));
            this.enderecoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.enderecoTextBox.Location = new System.Drawing.Point(129, 440);
            this.enderecoTextBox.Multiline = true;
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(464, 98);
            this.enderecoTextBox.TabIndex = 18;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClientesBindingSource, "email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.emailTextBox.Location = new System.Drawing.Point(129, 562);
            this.emailTextBox.Multiline = true;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(464, 33);
            this.emailTextBox.TabIndex = 20;
            // 
            // btnAdicionarImagem
            // 
            this.btnAdicionarImagem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdicionarImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarImagem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdicionarImagem.Location = new System.Drawing.Point(758, 340);
            this.btnAdicionarImagem.Name = "btnAdicionarImagem";
            this.btnAdicionarImagem.Size = new System.Drawing.Size(158, 33);
            this.btnAdicionarImagem.TabIndex = 23;
            this.btnAdicionarImagem.Text = "Selecionar Imagem";
            this.btnAdicionarImagem.UseVisualStyleBackColor = false;
            this.btnAdicionarImagem.Click += new System.EventHandler(this.btnAdicionarImagem_Click);
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
            this.btnSalvar.TabIndex = 25;
            this.btnSalvar.Text = "Salvar (F2)";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // sexoTextBox
            // 
            this.sexoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClientesBindingSource, "sexo", true));
            this.sexoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.sexoTextBox.Location = new System.Drawing.Point(525, 237);
            this.sexoTextBox.Multiline = true;
            this.sexoTextBox.Name = "sexoTextBox";
            this.sexoTextBox.Size = new System.Drawing.Size(189, 33);
            this.sexoTextBox.TabIndex = 12;
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.ForeColor = System.Drawing.Color.Black;
            this.lbSize.Location = new System.Drawing.Point(804, 237);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(65, 32);
            this.lbSize.TabIndex = 26;
            this.lbSize.Text = "SIZE:\r\n158X193";
            this.lbSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCadastro
            // 
            this.lbCadastro.AutoSize = true;
            this.lbCadastro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadastro.Location = new System.Drawing.Point(1, 84);
            this.lbCadastro.Name = "lbCadastro";
            this.lbCadastro.Size = new System.Drawing.Size(182, 25);
            this.lbCadastro.TabIndex = 27;
            this.lbCadastro.Text = "Cadastro Pessoal";
            this.lbCadastro.Click += new System.EventHandler(this.lbCadastro_Click);
            // 
            // lbAnimais
            // 
            this.lbAnimais.AutoSize = true;
            this.lbAnimais.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAnimais.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnimais.Location = new System.Drawing.Point(272, 84);
            this.lbAnimais.Name = "lbAnimais";
            this.lbAnimais.Size = new System.Drawing.Size(214, 25);
            this.lbAnimais.TabIndex = 28;
            this.lbAnimais.Text = "Cadastro De Animais";
            this.lbAnimais.Click += new System.EventHandler(this.lbAnimais_Click);
            // 
            // lbConsultas
            // 
            this.lbConsultas.AutoSize = true;
            this.lbConsultas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsultas.Location = new System.Drawing.Point(576, 84);
            this.lbConsultas.Name = "lbConsultas";
            this.lbConsultas.Size = new System.Drawing.Size(231, 25);
            this.lbConsultas.TabIndex = 29;
            this.lbConsultas.Text = "Cadastro de Consultas";
            this.lbConsultas.Click += new System.EventHandler(this.lbConsultas_Click);
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
            this.lbCancelar.TabIndex = 30;
            this.lbCancelar.Text = "Cancelar";
            this.lbCancelar.Click += new System.EventHandler(this.lbCancelar_Click);
            // 
            // pbImagemCliente
            // 
            this.pbImagemCliente.Location = new System.Drawing.Point(758, 141);
            this.pbImagemCliente.Name = "pbImagemCliente";
            this.pbImagemCliente.Size = new System.Drawing.Size(158, 193);
            this.pbImagemCliente.TabIndex = 24;
            this.pbImagemCliente.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SA_NOVA.Properties.Resources.utility;
            this.pictureBox1.Location = new System.Drawing.Point(-8, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(988, 648);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cadastroDeCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 621);
            this.Controls.Add(this.lbCancelar);
            this.Controls.Add(this.lbConsultas);
            this.Controls.Add(this.lbAnimais);
            this.Controls.Add(this.lbCadastro);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.pbImagemCliente);
            this.Controls.Add(this.btnAdicionarImagem);
            this.Controls.Add(idClientesLabel);
            this.Controls.Add(this.idClientesTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(data_nascimentoLabel);
            this.Controls.Add(this.data_nascimentoDateTimePicker);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(celularLabel);
            this.Controls.Add(this.celularTextBox);
            this.Controls.Add(sexoLabel);
            this.Controls.Add(this.sexoTextBox);
            this.Controls.Add(rgLabel);
            this.Controls.Add(this.rgTextBox);
            this.Controls.Add(cpfLabel);
            this.Controls.Add(this.cpfTextBox);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "cadastroDeCliente";
            this.Text = "Veterinary Clinic";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdVeterinariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bdVeterinariaDataSet bdVeterinariaDataSet;
        private System.Windows.Forms.BindingSource tbClientesBindingSource;
        private bdVeterinariaDataSetTableAdapters.tbClientesTableAdapter tbClientesTableAdapter;
        private bdVeterinariaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idClientesTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.DateTimePicker data_nascimentoDateTimePicker;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.TextBox celularTextBox;
        private System.Windows.Forms.TextBox rgTextBox;
        private System.Windows.Forms.TextBox cpfTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdicionarImagem;
        private System.Windows.Forms.PictureBox pbImagemCliente;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox sexoTextBox;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label lbCadastro;
        private System.Windows.Forms.Label lbAnimais;
        private System.Windows.Forms.Label lbConsultas;
        private System.Windows.Forms.Label lbCancelar;
    }
}