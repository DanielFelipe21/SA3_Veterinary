
namespace SA_NOVA
{
    partial class cadastroDeConsultasAvulso
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
            System.Windows.Forms.Label veterinarioLabel;
            System.Windows.Forms.Label pacienteLabel;
            System.Windows.Forms.Label consultaDataLabel;
            System.Windows.Forms.Label observacaoConsultaLabel;
            System.Windows.Forms.Label statusLabel;
            this.tbConsultasTableAdapter = new SA_NOVA.bdVeterinariaDataSetTableAdapters.tbConsultasTableAdapter();
            this.bdVeterinariaDataSet1 = new SA_NOVA.bdVeterinariaDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager1 = new SA_NOVA.bdVeterinariaDataSetTableAdapters.TableAdapterManager();
            this.tbClientesTableAdapter1 = new SA_NOVA.bdVeterinariaDataSetTableAdapters.tbClientesTableAdapter();
            this.tableAdapterManager = new SA_NOVA.bdVeterinariaDataSetTableAdapters.TableAdapterManager();
            this.tbClientesTableAdapter = new SA_NOVA.bdVeterinariaDataSetTableAdapters.tbClientesTableAdapter();
            this.idConsultaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.pacienteIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultaDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbVeterinarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdVeterinariaDataSet = new SA_NOVA.bdVeterinariaDataSet();
            this.tbVeterinarioTableAdapter = new SA_NOVA.bdVeterinariaDataSetTableAdapters.tbVeterinarioTableAdapter();
            this.veterinarioIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridViewConsultas = new System.Windows.Forms.DataGridView();
            this.tbConsultasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veterinarioTextBox = new System.Windows.Forms.TextBox();
            this.dataConsulta = new System.Windows.Forms.DateTimePicker();
            this.idConsultasTextBox = new System.Windows.Forms.TextBox();
            this.tbClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacienteTextBox = new System.Windows.Forms.TextBox();
            this.btnSalvarForm2 = new System.Windows.Forms.Button();
            this.lbConsultasConsultas = new System.Windows.Forms.Label();
            this.lbCadastroConsultas = new System.Windows.Forms.Label();
            this.lbCancelarForm2 = new System.Windows.Forms.Label();
            this.observacaoTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            idClientesLabel = new System.Windows.Forms.Label();
            veterinarioLabel = new System.Windows.Forms.Label();
            pacienteLabel = new System.Windows.Forms.Label();
            consultaDataLabel = new System.Windows.Forms.Label();
            observacaoConsultaLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdVeterinariaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVeterinarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdVeterinariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConsultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbConsultasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // idClientesLabel
            // 
            idClientesLabel.AutoSize = true;
            idClientesLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            idClientesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idClientesLabel.Location = new System.Drawing.Point(23, 150);
            idClientesLabel.Name = "idClientesLabel";
            idClientesLabel.Size = new System.Drawing.Size(76, 24);
            idClientesLabel.TabIndex = 154;
            idClientesLabel.Text = "Código:";
            // 
            // veterinarioLabel
            // 
            veterinarioLabel.AutoSize = true;
            veterinarioLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            veterinarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            veterinarioLabel.Location = new System.Drawing.Point(23, 189);
            veterinarioLabel.Name = "veterinarioLabel";
            veterinarioLabel.Size = new System.Drawing.Size(48, 24);
            veterinarioLabel.TabIndex = 156;
            veterinarioLabel.Text = "Vet.:";
            // 
            // pacienteLabel
            // 
            pacienteLabel.AutoSize = true;
            pacienteLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            pacienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            pacienteLabel.Location = new System.Drawing.Point(23, 228);
            pacienteLabel.Name = "pacienteLabel";
            pacienteLabel.Size = new System.Drawing.Size(88, 24);
            pacienteLabel.TabIndex = 158;
            pacienteLabel.Text = "Paciente:";
            // 
            // consultaDataLabel
            // 
            consultaDataLabel.AutoSize = true;
            consultaDataLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            consultaDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            consultaDataLabel.Location = new System.Drawing.Point(23, 289);
            consultaDataLabel.Name = "consultaDataLabel";
            consultaDataLabel.Size = new System.Drawing.Size(101, 24);
            consultaDataLabel.TabIndex = 160;
            consultaDataLabel.Text = "Data Cons:";
            // 
            // observacaoConsultaLabel
            // 
            observacaoConsultaLabel.AutoSize = true;
            observacaoConsultaLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            observacaoConsultaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            observacaoConsultaLabel.Location = new System.Drawing.Point(23, 339);
            observacaoConsultaLabel.Name = "observacaoConsultaLabel";
            observacaoConsultaLabel.Size = new System.Drawing.Size(55, 24);
            observacaoConsultaLabel.TabIndex = 162;
            observacaoConsultaLabel.Text = "Obs.:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            statusLabel.Location = new System.Drawing.Point(23, 467);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(65, 24);
            statusLabel.TabIndex = 164;
            statusLabel.Text = "Status:";
            // 
            // tbConsultasTableAdapter
            // 
            this.tbConsultasTableAdapter.ClearBeforeFill = true;
            // 
            // bdVeterinariaDataSet1
            // 
            this.bdVeterinariaDataSet1.DataSetName = "bdVeterinariaDataSet";
            this.bdVeterinariaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "tbClientes";
            this.bindingSource1.DataSource = this.bdVeterinariaDataSet1;
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
            // idConsultaDataGridViewTextBoxColumn
            // 
            this.idConsultaDataGridViewTextBoxColumn.DataPropertyName = "idConsulta";
            this.idConsultaDataGridViewTextBoxColumn.HeaderText = "idConsulta";
            this.idConsultaDataGridViewTextBoxColumn.Name = "idConsultaDataGridViewTextBoxColumn";
            this.idConsultaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(606, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(313, 23);
            this.button2.TabIndex = 169;
            this.button2.Text = "CONTROLE";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(471, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(447, 23);
            this.button1.TabIndex = 167;
            this.button1.Text = "CALENDÁRIO";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendar1.Location = new System.Drawing.Point(466, 151);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 166;
            // 
            // pacienteIdDataGridViewTextBoxColumn
            // 
            this.pacienteIdDataGridViewTextBoxColumn.DataPropertyName = "pacienteId";
            this.pacienteIdDataGridViewTextBoxColumn.HeaderText = "pacienteId";
            this.pacienteIdDataGridViewTextBoxColumn.Name = "pacienteIdDataGridViewTextBoxColumn";
            this.pacienteIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // consultaDataDataGridViewTextBoxColumn
            // 
            this.consultaDataDataGridViewTextBoxColumn.DataPropertyName = "consultaData";
            this.consultaDataDataGridViewTextBoxColumn.HeaderText = "consultaData";
            this.consultaDataDataGridViewTextBoxColumn.Name = "consultaDataDataGridViewTextBoxColumn";
            this.consultaDataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // observacaoDataGridViewTextBoxColumn
            // 
            this.observacaoDataGridViewTextBoxColumn.DataPropertyName = "observacao";
            this.observacaoDataGridViewTextBoxColumn.HeaderText = "observacao";
            this.observacaoDataGridViewTextBoxColumn.Name = "observacaoDataGridViewTextBoxColumn";
            this.observacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tbVeterinarioBindingSource
            // 
            this.tbVeterinarioBindingSource.DataMember = "tbVeterinario";
            this.tbVeterinarioBindingSource.DataSource = this.bdVeterinariaDataSet;
            // 
            // bdVeterinariaDataSet
            // 
            this.bdVeterinariaDataSet.DataSetName = "bdVeterinariaDataSet";
            this.bdVeterinariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbVeterinarioTableAdapter
            // 
            this.tbVeterinarioTableAdapter.ClearBeforeFill = true;
            // 
            // veterinarioIdDataGridViewTextBoxColumn
            // 
            this.veterinarioIdDataGridViewTextBoxColumn.DataPropertyName = "veterinarioId";
            this.veterinarioIdDataGridViewTextBoxColumn.HeaderText = "veterinarioId";
            this.veterinarioIdDataGridViewTextBoxColumn.Name = "veterinarioIdDataGridViewTextBoxColumn";
            this.veterinarioIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gridViewConsultas
            // 
            this.gridViewConsultas.AllowUserToAddRows = false;
            this.gridViewConsultas.AllowUserToDeleteRows = false;
            this.gridViewConsultas.AutoGenerateColumns = false;
            this.gridViewConsultas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridViewConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idConsultaDataGridViewTextBoxColumn,
            this.veterinarioIdDataGridViewTextBoxColumn,
            this.pacienteIdDataGridViewTextBoxColumn,
            this.consultaDataDataGridViewTextBoxColumn,
            this.observacaoDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.gridViewConsultas.DataSource = this.tbConsultasBindingSource;
            this.gridViewConsultas.Location = new System.Drawing.Point(607, 358);
            this.gridViewConsultas.Name = "gridViewConsultas";
            this.gridViewConsultas.ReadOnly = true;
            this.gridViewConsultas.Size = new System.Drawing.Size(311, 131);
            this.gridViewConsultas.TabIndex = 168;
            // 
            // tbConsultasBindingSource
            // 
            this.tbConsultasBindingSource.DataMember = "tbConsultas";
            this.tbConsultasBindingSource.DataSource = this.bdVeterinariaDataSet;
            // 
            // veterinarioTextBox
            // 
            this.veterinarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbConsultasBindingSource, "veterinarioId", true));
            this.veterinarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.veterinarioTextBox.Location = new System.Drawing.Point(127, 180);
            this.veterinarioTextBox.Multiline = true;
            this.veterinarioTextBox.Name = "veterinarioTextBox";
            this.veterinarioTextBox.Size = new System.Drawing.Size(327, 33);
            this.veterinarioTextBox.TabIndex = 157;
            // 
            // dataConsulta
            // 
            this.dataConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataConsulta.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbConsultasBindingSource, "consultaData", true));
            this.dataConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataConsulta.Location = new System.Drawing.Point(127, 279);
            this.dataConsulta.Margin = new System.Windows.Forms.Padding(1);
            this.dataConsulta.Name = "dataConsulta";
            this.dataConsulta.Size = new System.Drawing.Size(327, 34);
            this.dataConsulta.TabIndex = 159;
            this.dataConsulta.Value = new System.DateTime(2020, 12, 17, 0, 0, 0, 0);
            // 
            // idConsultasTextBox
            // 
            this.idConsultasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClientesBindingSource, "idClientes", true));
            this.idConsultasTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idConsultasTextBox.Location = new System.Drawing.Point(127, 141);
            this.idConsultasTextBox.Multiline = true;
            this.idConsultasTextBox.Name = "idConsultasTextBox";
            this.idConsultasTextBox.Size = new System.Drawing.Size(146, 33);
            this.idConsultasTextBox.TabIndex = 155;
            // 
            // tbClientesBindingSource
            // 
            this.tbClientesBindingSource.DataMember = "tbClientes";
            this.tbClientesBindingSource.DataSource = this.bdVeterinariaDataSet;
            // 
            // pacienteTextBox
            // 
            this.pacienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbConsultasBindingSource, "pacienteId", true));
            this.pacienteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.pacienteTextBox.Location = new System.Drawing.Point(128, 219);
            this.pacienteTextBox.Multiline = true;
            this.pacienteTextBox.Name = "pacienteTextBox";
            this.pacienteTextBox.Size = new System.Drawing.Size(326, 33);
            this.pacienteTextBox.TabIndex = 161;
            // 
            // btnSalvarForm2
            // 
            this.btnSalvarForm2.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSalvarForm2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarForm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarForm2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvarForm2.Location = new System.Drawing.Point(5, 16);
            this.btnSalvarForm2.Name = "btnSalvarForm2";
            this.btnSalvarForm2.Size = new System.Drawing.Size(132, 41);
            this.btnSalvarForm2.TabIndex = 146;
            this.btnSalvarForm2.Text = "Salvar (F2)";
            this.btnSalvarForm2.UseVisualStyleBackColor = false;
            this.btnSalvarForm2.Click += new System.EventHandler(this.btnSalvarForm2_Click_1);
            // 
            // lbConsultasConsultas
            // 
            this.lbConsultasConsultas.AutoSize = true;
            this.lbConsultasConsultas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbConsultasConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsultasConsultas.Location = new System.Drawing.Point(0, 84);
            this.lbConsultasConsultas.Name = "lbConsultasConsultas";
            this.lbConsultasConsultas.Size = new System.Drawing.Size(231, 25);
            this.lbConsultasConsultas.TabIndex = 153;
            this.lbConsultasConsultas.Text = "Cadastro de Consultas";
            // 
            // lbCadastroConsultas
            // 
            this.lbCadastroConsultas.AutoSize = true;
            this.lbCadastroConsultas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCadastroConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadastroConsultas.Location = new System.Drawing.Point(0, 84);
            this.lbCadastroConsultas.Name = "lbCadastroConsultas";
            this.lbCadastroConsultas.Size = new System.Drawing.Size(182, 25);
            this.lbCadastroConsultas.TabIndex = 151;
            this.lbCadastroConsultas.Text = "Cadastro Pessoal";
            // 
            // lbCancelarForm2
            // 
            this.lbCancelarForm2.AutoSize = true;
            this.lbCancelarForm2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCancelarForm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbCancelarForm2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbCancelarForm2.Location = new System.Drawing.Point(164, 26);
            this.lbCancelarForm2.Name = "lbCancelarForm2";
            this.lbCancelarForm2.Size = new System.Drawing.Size(80, 20);
            this.lbCancelarForm2.TabIndex = 150;
            this.lbCancelarForm2.Text = "Cancelar";
            this.lbCancelarForm2.Click += new System.EventHandler(this.lbCancelarForm2_Click_1);
            // 
            // observacaoTextBox
            // 
            this.observacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbConsultasBindingSource, "observacao", true));
            this.observacaoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.observacaoTextBox.Location = new System.Drawing.Point(127, 339);
            this.observacaoTextBox.Multiline = true;
            this.observacaoTextBox.Name = "observacaoTextBox";
            this.observacaoTextBox.Size = new System.Drawing.Size(464, 98);
            this.observacaoTextBox.TabIndex = 163;
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbConsultasBindingSource, "status", true));
            this.statusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.statusTextBox.Location = new System.Drawing.Point(127, 458);
            this.statusTextBox.Multiline = true;
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(464, 33);
            this.statusTextBox.TabIndex = 165;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SA_NOVA.Properties.Resources.utility;
            this.pictureBox1.Location = new System.Drawing.Point(-9, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(988, 648);
            this.pictureBox1.TabIndex = 145;
            this.pictureBox1.TabStop = false;
            // 
            // cadastroDeConsultasAvulso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 621);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.gridViewConsultas);
            this.Controls.Add(idClientesLabel);
            this.Controls.Add(veterinarioLabel);
            this.Controls.Add(this.veterinarioTextBox);
            this.Controls.Add(pacienteLabel);
            this.Controls.Add(this.dataConsulta);
            this.Controls.Add(consultaDataLabel);
            this.Controls.Add(this.idConsultasTextBox);
            this.Controls.Add(this.pacienteTextBox);
            this.Controls.Add(this.btnSalvarForm2);
            this.Controls.Add(observacaoConsultaLabel);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.lbConsultasConsultas);
            this.Controls.Add(this.lbCadastroConsultas);
            this.Controls.Add(this.lbCancelarForm2);
            this.Controls.Add(this.observacaoTextBox);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "cadastroDeConsultasAvulso";
            this.Text = "Veterinary Clinic";
            ((System.ComponentModel.ISupportInitialize)(this.bdVeterinariaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVeterinarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdVeterinariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConsultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbConsultasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bdVeterinariaDataSetTableAdapters.tbConsultasTableAdapter tbConsultasTableAdapter;
        private bdVeterinariaDataSet bdVeterinariaDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private bdVeterinariaDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private bdVeterinariaDataSetTableAdapters.tbClientesTableAdapter tbClientesTableAdapter1;
        private bdVeterinariaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private bdVeterinariaDataSetTableAdapters.tbClientesTableAdapter tbClientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idConsultaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacienteIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consultaDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tbVeterinarioBindingSource;
        private bdVeterinariaDataSet bdVeterinariaDataSet;
        private bdVeterinariaDataSetTableAdapters.tbVeterinarioTableAdapter tbVeterinarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn veterinarioIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView gridViewConsultas;
        private System.Windows.Forms.BindingSource tbConsultasBindingSource;
        private System.Windows.Forms.TextBox veterinarioTextBox;
        private System.Windows.Forms.DateTimePicker dataConsulta;
        private System.Windows.Forms.TextBox idConsultasTextBox;
        private System.Windows.Forms.BindingSource tbClientesBindingSource;
        private System.Windows.Forms.TextBox pacienteTextBox;
        private System.Windows.Forms.Button btnSalvarForm2;
        private System.Windows.Forms.Label lbConsultasConsultas;
        private System.Windows.Forms.Label lbCadastroConsultas;
        private System.Windows.Forms.Label lbCancelarForm2;
        private System.Windows.Forms.TextBox observacaoTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}