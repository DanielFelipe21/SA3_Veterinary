
namespace SA_NOVA
{
    partial class acompanharCadastros
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
            this.lbCancelar = new System.Windows.Forms.Label();
            this.lbConsultasAnimais = new System.Windows.Forms.Label();
            this.lbControleAnimais = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bdVeterinariaDataSet1 = new SA_NOVA.bdVeterinariaDataSet();
            this.tableAdapterManager1 = new SA_NOVA.bdVeterinariaDataSetTableAdapters.TableAdapterManager();
            this.tbClientesTableAdapter1 = new SA_NOVA.bdVeterinariaDataSetTableAdapters.tbClientesTableAdapter();
            this.lbControleCadastros = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.bdVeterinariaDataSet = new SA_NOVA.bdVeterinariaDataSet();
            this.lbCancelarForm2 = new System.Windows.Forms.Label();
            this.lbConsultasForm2 = new System.Windows.Forms.Label();
            this.lbAnimaisForm2 = new System.Windows.Forms.Label();
            this.lbCadastroForm2 = new System.Windows.Forms.Label();
            this.btnSalvarForm2 = new System.Windows.Forms.Button();
            this.tbClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbClientesTableAdapter = new SA_NOVA.bdVeterinariaDataSetTableAdapters.tbClientesTableAdapter();
            this.tableAdapterManager = new SA_NOVA.bdVeterinariaDataSetTableAdapters.TableAdapterManager();
            this.gridViewClientes = new System.Windows.Forms.DataGridView();
            this.idClientesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datanascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbClientesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tbClientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbClientesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdVeterinariaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdVeterinariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientesBindingSource2)).BeginInit();
            this.SuspendLayout();
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
            this.lbCancelar.TabIndex = 121;
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
            this.lbConsultasAnimais.Size = new System.Drawing.Size(225, 25);
            this.lbConsultasAnimais.TabIndex = 120;
            this.lbConsultasAnimais.Text = "Controle de Consultas";
            this.lbConsultasAnimais.Click += new System.EventHandler(this.lbConsultasAnimais_Click);
            // 
            // lbControleAnimais
            // 
            this.lbControleAnimais.AutoSize = true;
            this.lbControleAnimais.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbControleAnimais.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbControleAnimais.Location = new System.Drawing.Point(272, 84);
            this.lbControleAnimais.Name = "lbControleAnimais";
            this.lbControleAnimais.Size = new System.Drawing.Size(205, 25);
            this.lbControleAnimais.TabIndex = 119;
            this.lbControleAnimais.Text = "Controle de Animais";
            this.lbControleAnimais.Click += new System.EventHandler(this.lbControleAnimais_Click);
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
            // tbClientesTableAdapter1
            // 
            this.tbClientesTableAdapter1.ClearBeforeFill = true;
            // 
            // lbControleCadastros
            // 
            this.lbControleCadastros.AutoSize = true;
            this.lbControleCadastros.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbControleCadastros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbControleCadastros.Location = new System.Drawing.Point(1, 84);
            this.lbControleCadastros.Name = "lbControleCadastros";
            this.lbControleCadastros.Size = new System.Drawing.Size(230, 25);
            this.lbControleCadastros.TabIndex = 118;
            this.lbControleCadastros.Text = "Controle De Cadastros";
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
            this.btnSalvar.TabIndex = 116;
            this.btnSalvar.Text = "Salvar (F2)";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // bdVeterinariaDataSet
            // 
            this.bdVeterinariaDataSet.DataSetName = "bdVeterinariaDataSet";
            this.bdVeterinariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.lbCancelarForm2.TabIndex = 94;
            this.lbCancelarForm2.Text = "Cancelar";
            // 
            // lbConsultasForm2
            // 
            this.lbConsultasForm2.AutoSize = true;
            this.lbConsultasForm2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbConsultasForm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsultasForm2.Location = new System.Drawing.Point(576, 84);
            this.lbConsultasForm2.Name = "lbConsultasForm2";
            this.lbConsultasForm2.Size = new System.Drawing.Size(225, 25);
            this.lbConsultasForm2.TabIndex = 93;
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
            this.lbAnimaisForm2.TabIndex = 92;
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
            this.lbCadastroForm2.TabIndex = 91;
            this.lbCadastroForm2.Text = "Cadastro Pessoal";
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
            this.btnSalvarForm2.TabIndex = 90;
            this.btnSalvarForm2.Text = "Salvar (F2)";
            this.btnSalvarForm2.UseVisualStyleBackColor = false;
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
            // gridViewClientes
            // 
            this.gridViewClientes.AutoGenerateColumns = false;
            this.gridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClientesDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.datanascimentoDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.celularDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.rgDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.gridViewClientes.DataSource = this.tbClientesBindingSource3;
            this.gridViewClientes.Location = new System.Drawing.Point(12, 128);
            this.gridViewClientes.Name = "gridViewClientes";
            this.gridViewClientes.Size = new System.Drawing.Size(918, 472);
            this.gridViewClientes.TabIndex = 122;
            this.gridViewClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idClientesDataGridViewTextBoxColumn
            // 
            this.idClientesDataGridViewTextBoxColumn.DataPropertyName = "idClientes";
            this.idClientesDataGridViewTextBoxColumn.HeaderText = "idClientes";
            this.idClientesDataGridViewTextBoxColumn.Name = "idClientesDataGridViewTextBoxColumn";
            this.idClientesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // datanascimentoDataGridViewTextBoxColumn
            // 
            this.datanascimentoDataGridViewTextBoxColumn.DataPropertyName = "data_nascimento";
            this.datanascimentoDataGridViewTextBoxColumn.HeaderText = "data_nascimento";
            this.datanascimentoDataGridViewTextBoxColumn.Name = "datanascimentoDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // celularDataGridViewTextBoxColumn
            // 
            this.celularDataGridViewTextBoxColumn.DataPropertyName = "celular";
            this.celularDataGridViewTextBoxColumn.HeaderText = "celular";
            this.celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            // 
            // rgDataGridViewTextBoxColumn
            // 
            this.rgDataGridViewTextBoxColumn.DataPropertyName = "rg";
            this.rgDataGridViewTextBoxColumn.HeaderText = "rg";
            this.rgDataGridViewTextBoxColumn.Name = "rgDataGridViewTextBoxColumn";
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "cpf";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "endereco";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // tbClientesBindingSource3
            // 
            this.tbClientesBindingSource3.DataMember = "tbClientes";
            this.tbClientesBindingSource3.DataSource = this.bdVeterinariaDataSet1;
            // 
            // tbClientesBindingSource1
            // 
            this.tbClientesBindingSource1.DataMember = "tbClientes";
            this.tbClientesBindingSource1.DataSource = this.bdVeterinariaDataSet1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SA_NOVA.Properties.Resources.utility;
            this.pictureBox2.Location = new System.Drawing.Point(-8, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(988, 648);
            this.pictureBox2.TabIndex = 113;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SA_NOVA.Properties.Resources.utility;
            this.pictureBox1.Location = new System.Drawing.Point(-8, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(988, 648);
            this.pictureBox1.TabIndex = 89;
            this.pictureBox1.TabStop = false;
            // 
            // tbClientesBindingSource2
            // 
            this.tbClientesBindingSource2.DataMember = "tbClientes";
            this.tbClientesBindingSource2.DataSource = this.bdVeterinariaDataSet1;
            // 
            // acompanharCadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 621);
            this.Controls.Add(this.gridViewClientes);
            this.Controls.Add(this.lbCancelar);
            this.Controls.Add(this.lbConsultasAnimais);
            this.Controls.Add(this.lbControleAnimais);
            this.Controls.Add(this.lbControleCadastros);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbCancelarForm2);
            this.Controls.Add(this.lbConsultasForm2);
            this.Controls.Add(this.lbAnimaisForm2);
            this.Controls.Add(this.lbCadastroForm2);
            this.Controls.Add(this.btnSalvarForm2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "acompanharCadastros";
            this.Text = "Veterinary Clinic";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdVeterinariaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdVeterinariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientesBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCancelar;
        private System.Windows.Forms.Label lbConsultasAnimais;
        private System.Windows.Forms.Label lbControleAnimais;
        private System.Windows.Forms.BindingSource bindingSource1;
        private bdVeterinariaDataSet bdVeterinariaDataSet1;
        private bdVeterinariaDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private bdVeterinariaDataSetTableAdapters.tbClientesTableAdapter tbClientesTableAdapter1;
        private System.Windows.Forms.Label lbControleCadastros;
        private System.Windows.Forms.Button btnSalvar;
        private bdVeterinariaDataSet bdVeterinariaDataSet;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbCancelarForm2;
        private System.Windows.Forms.Label lbConsultasForm2;
        private System.Windows.Forms.Label lbAnimaisForm2;
        private System.Windows.Forms.Label lbCadastroForm2;
        private System.Windows.Forms.Button btnSalvarForm2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource tbClientesBindingSource;
        private bdVeterinariaDataSetTableAdapters.tbClientesTableAdapter tbClientesTableAdapter;
        private bdVeterinariaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView gridViewClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datanascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tbClientesBindingSource1;
        private System.Windows.Forms.BindingSource tbClientesBindingSource3;
        private System.Windows.Forms.BindingSource tbClientesBindingSource2;
    }
}