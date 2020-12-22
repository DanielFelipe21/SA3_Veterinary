
namespace SA_NOVA
{
    partial class acompanharConsultas
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gridViewConsultas = new System.Windows.Forms.DataGridView();
            this.idConsultaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veterinarioIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacienteIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultaDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbConsultasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdVeterinariaDataSet = new SA_NOVA.bdVeterinariaDataSet();
            this.tbConsultasTableAdapter = new SA_NOVA.bdVeterinariaDataSetTableAdapters.tbConsultasTableAdapter();
            this.lbCancelar = new System.Windows.Forms.Label();
            this.lbConsultasConsultas = new System.Windows.Forms.Label();
            this.lbControleAnimais = new System.Windows.Forms.Label();
            this.lbControleCadastros = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConsultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbConsultasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdVeterinariaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SA_NOVA.Properties.Resources.utility;
            this.pictureBox2.Location = new System.Drawing.Point(-8, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(988, 648);
            this.pictureBox2.TabIndex = 114;
            this.pictureBox2.TabStop = false;
            // 
            // gridViewConsultas
            // 
            this.gridViewConsultas.AutoGenerateColumns = false;
            this.gridViewConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idConsultaDataGridViewTextBoxColumn,
            this.veterinarioIdDataGridViewTextBoxColumn,
            this.pacienteIdDataGridViewTextBoxColumn,
            this.consultaDataDataGridViewTextBoxColumn,
            this.observacaoDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.gridViewConsultas.DataSource = this.tbConsultasBindingSource;
            this.gridViewConsultas.Location = new System.Drawing.Point(12, 128);
            this.gridViewConsultas.Name = "gridViewConsultas";
            this.gridViewConsultas.Size = new System.Drawing.Size(918, 472);
            this.gridViewConsultas.TabIndex = 123;
            // 
            // idConsultaDataGridViewTextBoxColumn
            // 
            this.idConsultaDataGridViewTextBoxColumn.DataPropertyName = "idConsulta";
            this.idConsultaDataGridViewTextBoxColumn.HeaderText = "idConsulta";
            this.idConsultaDataGridViewTextBoxColumn.Name = "idConsultaDataGridViewTextBoxColumn";
            this.idConsultaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // veterinarioIdDataGridViewTextBoxColumn
            // 
            this.veterinarioIdDataGridViewTextBoxColumn.DataPropertyName = "veterinarioId";
            this.veterinarioIdDataGridViewTextBoxColumn.HeaderText = "veterinarioId";
            this.veterinarioIdDataGridViewTextBoxColumn.Name = "veterinarioIdDataGridViewTextBoxColumn";
            // 
            // pacienteIdDataGridViewTextBoxColumn
            // 
            this.pacienteIdDataGridViewTextBoxColumn.DataPropertyName = "pacienteId";
            this.pacienteIdDataGridViewTextBoxColumn.HeaderText = "pacienteId";
            this.pacienteIdDataGridViewTextBoxColumn.Name = "pacienteIdDataGridViewTextBoxColumn";
            // 
            // consultaDataDataGridViewTextBoxColumn
            // 
            this.consultaDataDataGridViewTextBoxColumn.DataPropertyName = "consultaData";
            this.consultaDataDataGridViewTextBoxColumn.HeaderText = "consultaData";
            this.consultaDataDataGridViewTextBoxColumn.Name = "consultaDataDataGridViewTextBoxColumn";
            // 
            // observacaoDataGridViewTextBoxColumn
            // 
            this.observacaoDataGridViewTextBoxColumn.DataPropertyName = "observacao";
            this.observacaoDataGridViewTextBoxColumn.HeaderText = "observacao";
            this.observacaoDataGridViewTextBoxColumn.Name = "observacaoDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // tbConsultasBindingSource
            // 
            this.tbConsultasBindingSource.DataMember = "tbConsultas";
            this.tbConsultasBindingSource.DataSource = this.bdVeterinariaDataSet;
            // 
            // bdVeterinariaDataSet
            // 
            this.bdVeterinariaDataSet.DataSetName = "bdVeterinariaDataSet";
            this.bdVeterinariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbConsultasTableAdapter
            // 
            this.tbConsultasTableAdapter.ClearBeforeFill = true;
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
            this.lbCancelar.TabIndex = 128;
            this.lbCancelar.Text = "Cancelar";
            this.lbCancelar.Click += new System.EventHandler(this.lbCancelar_Click);
            // 
            // lbConsultasConsultas
            // 
            this.lbConsultasConsultas.AutoSize = true;
            this.lbConsultasConsultas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbConsultasConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsultasConsultas.Location = new System.Drawing.Point(576, 84);
            this.lbConsultasConsultas.Name = "lbConsultasConsultas";
            this.lbConsultasConsultas.Size = new System.Drawing.Size(225, 25);
            this.lbConsultasConsultas.TabIndex = 127;
            this.lbConsultasConsultas.Text = "Controle de Consultas";
            // 
            // lbControleAnimais
            // 
            this.lbControleAnimais.AutoSize = true;
            this.lbControleAnimais.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbControleAnimais.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbControleAnimais.Location = new System.Drawing.Point(272, 84);
            this.lbControleAnimais.Name = "lbControleAnimais";
            this.lbControleAnimais.Size = new System.Drawing.Size(205, 25);
            this.lbControleAnimais.TabIndex = 126;
            this.lbControleAnimais.Text = "Controle de Animais";
            this.lbControleAnimais.Click += new System.EventHandler(this.lbControleAnimais_Click);
            // 
            // lbControleCadastros
            // 
            this.lbControleCadastros.AutoSize = true;
            this.lbControleCadastros.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbControleCadastros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbControleCadastros.Location = new System.Drawing.Point(1, 84);
            this.lbControleCadastros.Name = "lbControleCadastros";
            this.lbControleCadastros.Size = new System.Drawing.Size(230, 25);
            this.lbControleCadastros.TabIndex = 125;
            this.lbControleCadastros.Text = "Controle De Cadastros";
            this.lbControleCadastros.Click += new System.EventHandler(this.lbControleCadastros_Click);
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
            this.btnSalvar.TabIndex = 124;
            this.btnSalvar.Text = "Salvar (F2)";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // acompanharConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 621);
            this.Controls.Add(this.lbCancelar);
            this.Controls.Add(this.lbConsultasConsultas);
            this.Controls.Add(this.lbControleAnimais);
            this.Controls.Add(this.lbControleCadastros);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gridViewConsultas);
            this.Controls.Add(this.pictureBox2);
            this.Name = "acompanharConsultas";
            this.Text = "Veterinary Clinic";
            this.Load += new System.EventHandler(this.acompanharConsultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConsultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbConsultasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdVeterinariaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView gridViewConsultas;
        private bdVeterinariaDataSet bdVeterinariaDataSet;
        private System.Windows.Forms.BindingSource tbConsultasBindingSource;
        private bdVeterinariaDataSetTableAdapters.tbConsultasTableAdapter tbConsultasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idConsultaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veterinarioIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacienteIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consultaDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbCancelar;
        private System.Windows.Forms.Label lbConsultasConsultas;
        private System.Windows.Forms.Label lbControleAnimais;
        private System.Windows.Forms.Label lbControleCadastros;
        private System.Windows.Forms.Button btnSalvar;
    }
}