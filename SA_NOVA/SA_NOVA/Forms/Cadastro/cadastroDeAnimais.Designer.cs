
namespace SA_NOVA
{
    partial class cadastroDeAnimais
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
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label cpfLabel;
            System.Windows.Forms.Label rgLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label celularLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label data_nascimentoLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label idClientesLabel;
            this.lbCancelarForm2 = new System.Windows.Forms.Label();
            this.lbConsultasForm2 = new System.Windows.Forms.Label();
            this.lbAnimaisForm2 = new System.Windows.Forms.Label();
            this.lbCadastroForm2 = new System.Windows.Forms.Label();
            this.btnSalvarForm2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdVeterinariaDataSet = new SA_NOVA.bdVeterinariaDataSet();
            this.tableAdapterManager = new SA_NOVA.bdVeterinariaDataSetTableAdapters.TableAdapterManager();
            this.tbClientesTableAdapter = new SA_NOVA.bdVeterinariaDataSetTableAdapters.tbClientesTableAdapter();
            this.tbClientesTableAdapter1 = new SA_NOVA.bdVeterinariaDataSetTableAdapters.tbClientesTableAdapter();
            this.tableAdapterManager1 = new SA_NOVA.bdVeterinariaDataSetTableAdapters.TableAdapterManager();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bdVeterinariaDataSet1 = new SA_NOVA.bdVeterinariaDataSet();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.observacaoTextBoxAnimais = new System.Windows.Forms.TextBox();
            this.porteTextBoxAnimais = new System.Windows.Forms.TextBox();
            this.pelugemTextBoxAnimais = new System.Windows.Forms.TextBox();
            this.sexoTextBoxAnimais = new System.Windows.Forms.TextBox();
            this.racaTextBoxAnimais = new System.Windows.Forms.TextBox();
            this.idadeTextBoxAnimais = new System.Windows.Forms.TextBox();
            this.data_nascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nomeTextBoxAnimais = new System.Windows.Forms.TextBox();
            this.idAnimaisTextBoxAnimais = new System.Windows.Forms.TextBox();
            this.btnAdicionarImagemAnimais = new System.Windows.Forms.Button();
            this.pbImagemAnimais = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lbSize = new System.Windows.Forms.Label();
            this.lbAnimaisAnimais = new System.Windows.Forms.Label();
            this.lbCancelar = new System.Windows.Forms.Label();
            this.lbConsultasAnimais = new System.Windows.Forms.Label();
            this.lbCadastroAnimais = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            cpfLabel = new System.Windows.Forms.Label();
            rgLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            data_nascimentoLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            idClientesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdVeterinariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdVeterinariaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemAnimais)).BeginInit();
            this.SuspendLayout();
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            enderecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            enderecoLabel.Location = new System.Drawing.Point(25, 440);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(55, 24);
            enderecoLabel.TabIndex = 76;
            enderecoLabel.Text = "Obs.:";
            // 
            // cpfLabel
            // 
            cpfLabel.AutoSize = true;
            cpfLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            cpfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            cpfLabel.Location = new System.Drawing.Point(25, 389);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new System.Drawing.Size(59, 24);
            cpfLabel.TabIndex = 74;
            cpfLabel.Text = "Porte:";
            // 
            // rgLabel
            // 
            rgLabel.AutoSize = true;
            rgLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            rgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            rgLabel.Location = new System.Drawing.Point(25, 349);
            rgLabel.Name = "rgLabel";
            rgLabel.Size = new System.Drawing.Size(91, 24);
            rgLabel.TabIndex = 72;
            rgLabel.Text = "Pelugem:";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            sexoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            sexoLabel.Location = new System.Drawing.Point(460, 246);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(59, 24);
            sexoLabel.TabIndex = 70;
            sexoLabel.Text = "Sexo:";
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            celularLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            celularLabel.Location = new System.Drawing.Point(460, 289);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(58, 24);
            celularLabel.TabIndex = 68;
            celularLabel.Text = "Raça:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            telefoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            telefoneLabel.Location = new System.Drawing.Point(25, 289);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(62, 24);
            telefoneLabel.TabIndex = 66;
            telefoneLabel.Text = "Idade:";
            // 
            // data_nascimentoLabel
            // 
            data_nascimentoLabel.AutoSize = true;
            data_nascimentoLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            data_nascimentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            data_nascimentoLabel.Location = new System.Drawing.Point(25, 246);
            data_nascimentoLabel.Name = "data_nascimentoLabel";
            data_nascimentoLabel.Size = new System.Drawing.Size(100, 24);
            data_nascimentoLabel.TabIndex = 64;
            data_nascimentoLabel.Text = "Data Nasc.";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            nomeLabel.Location = new System.Drawing.Point(25, 189);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(67, 24);
            nomeLabel.TabIndex = 62;
            nomeLabel.Text = "Nome:";
            // 
            // idClientesLabel
            // 
            idClientesLabel.AutoSize = true;
            idClientesLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            idClientesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idClientesLabel.Location = new System.Drawing.Point(25, 150);
            idClientesLabel.Name = "idClientesLabel";
            idClientesLabel.Size = new System.Drawing.Size(76, 24);
            idClientesLabel.TabIndex = 60;
            idClientesLabel.Text = "Código:";
            // 
            // lbCancelarForm2
            // 
            this.lbCancelarForm2.AutoSize = true;
            this.lbCancelarForm2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCancelarForm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbCancelarForm2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbCancelarForm2.Location = new System.Drawing.Point(165, 26);
            this.lbCancelarForm2.Name = "lbCancelarForm2";
            this.lbCancelarForm2.Size = new System.Drawing.Size(80, 20);
            this.lbCancelarForm2.TabIndex = 59;
            this.lbCancelarForm2.Text = "Cancelar";
            this.lbCancelarForm2.Click += new System.EventHandler(this.lbCancelarForm2_Click);
            // 
            // lbConsultasForm2
            // 
            this.lbConsultasForm2.AutoSize = true;
            this.lbConsultasForm2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbConsultasForm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsultasForm2.Location = new System.Drawing.Point(576, 84);
            this.lbConsultasForm2.Name = "lbConsultasForm2";
            this.lbConsultasForm2.Size = new System.Drawing.Size(225, 25);
            this.lbConsultasForm2.TabIndex = 58;
            this.lbConsultasForm2.Text = "Controle de Consultas";
            // 
            // lbAnimaisForm2
            // 
            this.lbAnimaisForm2.AutoSize = true;
            this.lbAnimaisForm2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAnimaisForm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnimaisForm2.Location = new System.Drawing.Point(272, 84);
            this.lbAnimaisForm2.Name = "lbAnimaisForm2";
            this.lbAnimaisForm2.Size = new System.Drawing.Size(214, 25);
            this.lbAnimaisForm2.TabIndex = 57;
            this.lbAnimaisForm2.Text = "Cadastro De Animais";
            // 
            // lbCadastroForm2
            // 
            this.lbCadastroForm2.AutoSize = true;
            this.lbCadastroForm2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCadastroForm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadastroForm2.Location = new System.Drawing.Point(1, 84);
            this.lbCadastroForm2.Name = "lbCadastroForm2";
            this.lbCadastroForm2.Size = new System.Drawing.Size(182, 25);
            this.lbCadastroForm2.TabIndex = 56;
            this.lbCadastroForm2.Text = "Cadastro Pessoal";
            this.lbCadastroForm2.Click += new System.EventHandler(this.lbCadastroForm2_Click);
            // 
            // btnSalvarForm2
            // 
            this.btnSalvarForm2.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSalvarForm2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarForm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarForm2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvarForm2.Location = new System.Drawing.Point(6, 16);
            this.btnSalvarForm2.Name = "btnSalvarForm2";
            this.btnSalvarForm2.Size = new System.Drawing.Size(132, 41);
            this.btnSalvarForm2.TabIndex = 54;
            this.btnSalvarForm2.Text = "Salvar (F2)";
            this.btnSalvarForm2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SA_NOVA.Properties.Resources.utility;
            this.pictureBox1.Location = new System.Drawing.Point(-8, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(988, 648);
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            // tbClientesTableAdapter1
            // 
            this.tbClientesTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.tbAnimaisTableAdapter = null;
            this.tableAdapterManager1.tbClientesTableAdapter = this.tbClientesTableAdapter1;
            this.tableAdapterManager1.tbConsultasTableAdapter = null;
            this.tableAdapterManager1.tbLoginTableAdapter = null;
            this.tableAdapterManager1.tbVeterinarioTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = SA_NOVA.bdVeterinariaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "tbClientes";
            this.bindingSource1.DataSource = this.bdVeterinariaDataSet1;
            // 
            // bdVeterinariaDataSet1
            // 
            this.bdVeterinariaDataSet1.DataSetName = "bdVeterinariaDataSet";
            this.bdVeterinariaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SA_NOVA.Properties.Resources.utility;
            this.pictureBox2.Location = new System.Drawing.Point(-8, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(988, 648);
            this.pictureBox2.TabIndex = 80;
            this.pictureBox2.TabStop = false;
            // 
            // observacaoTextBoxAnimais
            // 
            this.observacaoTextBoxAnimais.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdVeterinariaDataSet1, "tbAnimais.observacao", true));
            this.observacaoTextBoxAnimais.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.observacaoTextBoxAnimais.Location = new System.Drawing.Point(129, 440);
            this.observacaoTextBoxAnimais.Multiline = true;
            this.observacaoTextBoxAnimais.Name = "observacaoTextBoxAnimais";
            this.observacaoTextBoxAnimais.Size = new System.Drawing.Size(464, 98);
            this.observacaoTextBoxAnimais.TabIndex = 77;
            // 
            // porteTextBoxAnimais
            // 
            this.porteTextBoxAnimais.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdVeterinariaDataSet1, "tbAnimais.porte", true));
            this.porteTextBoxAnimais.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.porteTextBoxAnimais.Location = new System.Drawing.Point(129, 380);
            this.porteTextBoxAnimais.Multiline = true;
            this.porteTextBoxAnimais.Name = "porteTextBoxAnimais";
            this.porteTextBoxAnimais.Size = new System.Drawing.Size(238, 33);
            this.porteTextBoxAnimais.TabIndex = 75;
            // 
            // pelugemTextBoxAnimais
            // 
            this.pelugemTextBoxAnimais.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdVeterinariaDataSet1, "tbAnimais.pelugem", true));
            this.pelugemTextBoxAnimais.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.pelugemTextBoxAnimais.Location = new System.Drawing.Point(129, 340);
            this.pelugemTextBoxAnimais.Multiline = true;
            this.pelugemTextBoxAnimais.Name = "pelugemTextBoxAnimais";
            this.pelugemTextBoxAnimais.Size = new System.Drawing.Size(237, 33);
            this.pelugemTextBoxAnimais.TabIndex = 73;
            // 
            // sexoTextBoxAnimais
            // 
            this.sexoTextBoxAnimais.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdVeterinariaDataSet1, "tbAnimais.sexo", true));
            this.sexoTextBoxAnimais.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.sexoTextBoxAnimais.Location = new System.Drawing.Point(525, 237);
            this.sexoTextBoxAnimais.Multiline = true;
            this.sexoTextBoxAnimais.Name = "sexoTextBoxAnimais";
            this.sexoTextBoxAnimais.Size = new System.Drawing.Size(189, 33);
            this.sexoTextBoxAnimais.TabIndex = 71;
            // 
            // racaTextBoxAnimais
            // 
            this.racaTextBoxAnimais.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdVeterinariaDataSet1, "tbAnimais.raca", true));
            this.racaTextBoxAnimais.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.racaTextBoxAnimais.Location = new System.Drawing.Point(525, 280);
            this.racaTextBoxAnimais.Multiline = true;
            this.racaTextBoxAnimais.Name = "racaTextBoxAnimais";
            this.racaTextBoxAnimais.Size = new System.Drawing.Size(189, 33);
            this.racaTextBoxAnimais.TabIndex = 69;
            // 
            // idadeTextBoxAnimais
            // 
            this.idadeTextBoxAnimais.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdVeterinariaDataSet1, "tbAnimais.idade", true));
            this.idadeTextBoxAnimais.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.idadeTextBoxAnimais.Location = new System.Drawing.Point(129, 280);
            this.idadeTextBoxAnimais.Multiline = true;
            this.idadeTextBoxAnimais.Name = "idadeTextBoxAnimais";
            this.idadeTextBoxAnimais.Size = new System.Drawing.Size(237, 33);
            this.idadeTextBoxAnimais.TabIndex = 67;
            // 
            // data_nascimentoDateTimePicker
            // 
            this.data_nascimentoDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_nascimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdVeterinariaDataSet, "tbAnimais.data_nascimento", true));
            this.data_nascimentoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_nascimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_nascimentoDateTimePicker.Location = new System.Drawing.Point(129, 235);
            this.data_nascimentoDateTimePicker.Margin = new System.Windows.Forms.Padding(1);
            this.data_nascimentoDateTimePicker.Name = "data_nascimentoDateTimePicker";
            this.data_nascimentoDateTimePicker.Size = new System.Drawing.Size(238, 34);
            this.data_nascimentoDateTimePicker.TabIndex = 65;
            // 
            // nomeTextBoxAnimais
            // 
            this.nomeTextBoxAnimais.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdVeterinariaDataSet, "tbAnimais.nome", true));
            this.nomeTextBoxAnimais.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.nomeTextBoxAnimais.Location = new System.Drawing.Point(129, 180);
            this.nomeTextBoxAnimais.Multiline = true;
            this.nomeTextBoxAnimais.Name = "nomeTextBoxAnimais";
            this.nomeTextBoxAnimais.Size = new System.Drawing.Size(585, 33);
            this.nomeTextBoxAnimais.TabIndex = 63;
            // 
            // idAnimaisTextBoxAnimais
            // 
            this.idAnimaisTextBoxAnimais.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "idClientes", true));
            this.idAnimaisTextBoxAnimais.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idAnimaisTextBoxAnimais.Location = new System.Drawing.Point(129, 141);
            this.idAnimaisTextBoxAnimais.Multiline = true;
            this.idAnimaisTextBoxAnimais.Name = "idAnimaisTextBoxAnimais";
            this.idAnimaisTextBoxAnimais.Size = new System.Drawing.Size(146, 33);
            this.idAnimaisTextBoxAnimais.TabIndex = 61;
            // 
            // btnAdicionarImagemAnimais
            // 
            this.btnAdicionarImagemAnimais.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdicionarImagemAnimais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarImagemAnimais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarImagemAnimais.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdicionarImagemAnimais.Location = new System.Drawing.Point(758, 340);
            this.btnAdicionarImagemAnimais.Name = "btnAdicionarImagemAnimais";
            this.btnAdicionarImagemAnimais.Size = new System.Drawing.Size(158, 33);
            this.btnAdicionarImagemAnimais.TabIndex = 81;
            this.btnAdicionarImagemAnimais.Text = "Selecionar Imagem";
            this.btnAdicionarImagemAnimais.UseVisualStyleBackColor = false;
            // 
            // pbImagemAnimais
            // 
            this.pbImagemAnimais.Location = new System.Drawing.Point(758, 141);
            this.pbImagemAnimais.Name = "pbImagemAnimais";
            this.pbImagemAnimais.Size = new System.Drawing.Size(158, 193);
            this.pbImagemAnimais.TabIndex = 82;
            this.pbImagemAnimais.TabStop = false;
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
            this.btnSalvar.TabIndex = 83;
            this.btnSalvar.Text = "Salvar (F2)";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.ForeColor = System.Drawing.Color.Black;
            this.lbSize.Location = new System.Drawing.Point(804, 237);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(65, 32);
            this.lbSize.TabIndex = 84;
            this.lbSize.Text = "SIZE:\r\n158X193";
            this.lbSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAnimaisAnimais
            // 
            this.lbAnimaisAnimais.AutoSize = true;
            this.lbAnimaisAnimais.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAnimaisAnimais.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnimaisAnimais.Location = new System.Drawing.Point(272, 84);
            this.lbAnimaisAnimais.Name = "lbAnimaisAnimais";
            this.lbAnimaisAnimais.Size = new System.Drawing.Size(214, 25);
            this.lbAnimaisAnimais.TabIndex = 86;
            this.lbAnimaisAnimais.Text = "Cadastro De Animais";
            this.lbAnimaisAnimais.Click += new System.EventHandler(this.lbAnimaisAnimais_Click);
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
            this.lbCancelar.TabIndex = 88;
            this.lbCancelar.Text = "Cancelar";
            this.lbCancelar.Click += new System.EventHandler(this.lbCancelar_Click);
            // 
            // lbConsultasAnimais
            // 
            this.lbConsultasAnimais.AutoSize = true;
            this.lbConsultasAnimais.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbConsultasAnimais.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsultasAnimais.Location = new System.Drawing.Point(576, 84);
            this.lbConsultasAnimais.Name = "lbConsultasAnimais";
            this.lbConsultasAnimais.Size = new System.Drawing.Size(231, 25);
            this.lbConsultasAnimais.TabIndex = 87;
            this.lbConsultasAnimais.Text = "Cadastro de Consultas";
            this.lbConsultasAnimais.Click += new System.EventHandler(this.lbConsultasAnimais_Click);
            // 
            // lbCadastroAnimais
            // 
            this.lbCadastroAnimais.AutoSize = true;
            this.lbCadastroAnimais.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCadastroAnimais.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadastroAnimais.Location = new System.Drawing.Point(1, 84);
            this.lbCadastroAnimais.Name = "lbCadastroAnimais";
            this.lbCadastroAnimais.Size = new System.Drawing.Size(182, 25);
            this.lbCadastroAnimais.TabIndex = 85;
            this.lbCadastroAnimais.Text = "Cadastro Pessoal";
            this.lbCadastroAnimais.Click += new System.EventHandler(this.lbCadastro_Click);
            // 
            // cadastroDeAnimais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 621);
            this.Controls.Add(this.lbCancelar);
            this.Controls.Add(this.lbConsultasAnimais);
            this.Controls.Add(this.lbAnimaisAnimais);
            this.Controls.Add(this.lbCadastroAnimais);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.pbImagemAnimais);
            this.Controls.Add(this.btnAdicionarImagemAnimais);
            this.Controls.Add(idClientesLabel);
            this.Controls.Add(this.idAnimaisTextBoxAnimais);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBoxAnimais);
            this.Controls.Add(data_nascimentoLabel);
            this.Controls.Add(this.data_nascimentoDateTimePicker);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.idadeTextBoxAnimais);
            this.Controls.Add(celularLabel);
            this.Controls.Add(this.racaTextBoxAnimais);
            this.Controls.Add(sexoLabel);
            this.Controls.Add(this.sexoTextBoxAnimais);
            this.Controls.Add(rgLabel);
            this.Controls.Add(this.pelugemTextBoxAnimais);
            this.Controls.Add(cpfLabel);
            this.Controls.Add(this.porteTextBoxAnimais);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.observacaoTextBoxAnimais);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbCancelarForm2);
            this.Controls.Add(this.lbConsultasForm2);
            this.Controls.Add(this.lbAnimaisForm2);
            this.Controls.Add(this.lbCadastroForm2);
            this.Controls.Add(this.btnSalvarForm2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "cadastroDeAnimais";
            this.Text = "Veterinary Clinic";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdVeterinariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdVeterinariaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemAnimais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCancelarForm2;
        private System.Windows.Forms.Label lbConsultasForm2;
        private System.Windows.Forms.Label lbAnimaisForm2;
        private System.Windows.Forms.Label lbCadastroForm2;
        private System.Windows.Forms.Button btnSalvarForm2;
        private System.Windows.Forms.BindingSource tbClientesBindingSource;
        private bdVeterinariaDataSet bdVeterinariaDataSet;
        private bdVeterinariaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private bdVeterinariaDataSetTableAdapters.tbClientesTableAdapter tbClientesTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private bdVeterinariaDataSetTableAdapters.tbClientesTableAdapter tbClientesTableAdapter1;
        private bdVeterinariaDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private bdVeterinariaDataSet bdVeterinariaDataSet1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox observacaoTextBoxAnimais;
        private System.Windows.Forms.TextBox porteTextBoxAnimais;
        private System.Windows.Forms.TextBox pelugemTextBoxAnimais;
        private System.Windows.Forms.TextBox sexoTextBoxAnimais;
        private System.Windows.Forms.TextBox racaTextBoxAnimais;
        private System.Windows.Forms.TextBox idadeTextBoxAnimais;
        private System.Windows.Forms.DateTimePicker data_nascimentoDateTimePicker;
        private System.Windows.Forms.TextBox nomeTextBoxAnimais;
        private System.Windows.Forms.TextBox idAnimaisTextBoxAnimais;
        private System.Windows.Forms.Button btnAdicionarImagemAnimais;
        private System.Windows.Forms.PictureBox pbImagemAnimais;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label lbAnimaisAnimais;
        private System.Windows.Forms.Label lbCancelar;
        private System.Windows.Forms.Label lbConsultasAnimais;
        private System.Windows.Forms.Label lbCadastroAnimais;
    }
}