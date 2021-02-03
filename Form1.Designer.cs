namespace OrganizerParking
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lbEsqueciSenha = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblRegister = new System.Windows.Forms.Label();
            this.lbCreateAccount = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MV Boli", 35.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(203, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(410, 62);
            this.label5.TabIndex = 11;
            this.label5.Text = "Organizer Parking";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUser.Location = new System.Drawing.Point(118, 134);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(102, 25);
            this.lblUser.TabIndex = 12;
            this.lblUser.Text = "Username";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(276, 134);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(337, 30);
            this.txtUser.TabIndex = 13;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(276, 193);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(337, 30);
            this.txtPass.TabIndex = 14;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblPass.Location = new System.Drawing.Point(118, 193);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(109, 25);
            this.lblPass.TabIndex = 15;
            this.lblPass.Text = "Passaword";
            // 
            // lbEsqueciSenha
            // 
            this.lbEsqueciSenha.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.lbEsqueciSenha.AutoSize = true;
            this.lbEsqueciSenha.BackColor = System.Drawing.Color.Transparent;
            this.lbEsqueciSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEsqueciSenha.LinkColor = System.Drawing.Color.Red;
            this.lbEsqueciSenha.Location = new System.Drawing.Point(370, 245);
            this.lbEsqueciSenha.Name = "lbEsqueciSenha";
            this.lbEsqueciSenha.Size = new System.Drawing.Size(128, 15);
            this.lbEsqueciSenha.TabIndex = 16;
            this.lbEsqueciSenha.TabStop = true;
            this.lbEsqueciSenha.Text = "Esqueci Minha Senha";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(334, 276);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(193, 46);
            this.btnLogin.TabIndex = 17;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.BackColor = System.Drawing.Color.Transparent;
            this.lblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.ForeColor = System.Drawing.Color.Black;
            this.lblRegister.Location = new System.Drawing.Point(312, 357);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(96, 15);
            this.lblRegister.TabIndex = 18;
            this.lblRegister.Text = "Not Registered?";
            this.lblRegister.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbCreateAccount
            // 
            this.lbCreateAccount.AutoSize = true;
            this.lbCreateAccount.BackColor = System.Drawing.Color.Transparent;
            this.lbCreateAccount.DisabledLinkColor = System.Drawing.Color.Red;
            this.lbCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreateAccount.LinkColor = System.Drawing.Color.Red;
            this.lbCreateAccount.Location = new System.Drawing.Point(416, 357);
            this.lbCreateAccount.Name = "lbCreateAccount";
            this.lbCreateAccount.Size = new System.Drawing.Size(109, 15);
            this.lbCreateAccount.TabIndex = 19;
            this.lbCreateAccount.TabStop = true;
            this.lbCreateAccount.Text = "Create  An Account";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(113, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(593, 312);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OrganizerParking.Properties.Resources.azzolinadvogados_com_br_responsabilidade_fornecedor_veiculos_no_estacionamento_3375_01;
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.Controls.Add(this.lbCreateAccount);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lbEsqueciSenha);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Name = "Form1";
            this.Text = "Organizer Parking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.LinkLabel lbEsqueciSenha;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.LinkLabel lbCreateAccount;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

