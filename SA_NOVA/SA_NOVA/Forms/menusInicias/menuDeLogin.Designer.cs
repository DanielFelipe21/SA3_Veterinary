
namespace SA_NOVA
{
    partial class menuDeLogin
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
            System.Windows.Forms.Label lbLogin;
            System.Windows.Forms.Label lbSenha;
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lbConexao = new System.Windows.Forms.Label();
            this.lbErrorLogin = new System.Windows.Forms.Label();
            this.lbErrorSenha = new System.Windows.Forms.Label();
            lbLogin = new System.Windows.Forms.Label();
            lbSenha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbLogin.Location = new System.Drawing.Point(183, 226);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new System.Drawing.Size(62, 24);
            lbLogin.TabIndex = 33;
            lbLogin.Text = "Login:";
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            lbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbSenha.Location = new System.Drawing.Point(183, 293);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new System.Drawing.Size(70, 24);
            lbSenha.TabIndex = 36;
            lbSenha.Text = "Senha:";
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConectar.Location = new System.Drawing.Point(74, 359);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(271, 41);
            this.btnConectar.TabIndex = 26;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_ClickAsync);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DimGray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(74, 406);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(271, 41);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SA_NOVA.Properties.Resources._0157_h_bonnyville_veterinary_logo_13;
            this.pictureBox1.Location = new System.Drawing.Point(7, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(403, 210);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(74, 253);
            this.txtLogin.Multiline = true;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(271, 33);
            this.txtLogin.TabIndex = 34;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(74, 320);
            this.txtSenha.Multiline = true;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(271, 33);
            this.txtSenha.TabIndex = 35;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // lbConexao
            // 
            this.lbConexao.AutoSize = true;
            this.lbConexao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConexao.Location = new System.Drawing.Point(155, 455);
            this.lbConexao.Name = "lbConexao";
            this.lbConexao.Size = new System.Drawing.Size(117, 18);
            this.lbConexao.TabIndex = 37;
            this.lbConexao.Text = "labelDeConexao";
            // 
            // lbErrorLogin
            // 
            this.lbErrorLogin.AutoSize = true;
            this.lbErrorLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorLogin.Location = new System.Drawing.Point(77, 261);
            this.lbErrorLogin.Name = "lbErrorLogin";
            this.lbErrorLogin.Size = new System.Drawing.Size(93, 18);
            this.lbErrorLogin.TabIndex = 38;
            this.lbErrorLogin.Text = "labelDeLogin";
            // 
            // lbErrorSenha
            // 
            this.lbErrorSenha.AutoSize = true;
            this.lbErrorSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorSenha.Location = new System.Drawing.Point(77, 328);
            this.lbErrorSenha.Name = "lbErrorSenha";
            this.lbErrorSenha.Size = new System.Drawing.Size(99, 18);
            this.lbErrorSenha.TabIndex = 39;
            this.lbErrorSenha.Text = "labelDeSenha";
            // 
            // menuDeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(419, 489);
            this.Controls.Add(this.lbErrorSenha);
            this.Controls.Add(this.lbErrorLogin);
            this.Controls.Add(this.lbConexao);
            this.Controls.Add(lbSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(lbLogin);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConectar);
            this.Name = "menuDeLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veterinary Clinic";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lbConexao;
        private System.Windows.Forms.Label lbErrorLogin;
        private System.Windows.Forms.Label lbErrorSenha;
    }
}