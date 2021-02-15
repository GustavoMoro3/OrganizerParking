namespace OrganizerParking
{
    partial class PerfilEmpresa
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
            this.lblPerfil = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblPerfilClick = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(276, 40);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(91, 38);
            this.lblPerfil.TabIndex = 0;
            this.lblPerfil.Text = "Perfil";
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(73, 157);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 31);
            this.lblMensagem.TabIndex = 1;
            // 
            // lblPerfilClick
            // 
            this.lblPerfilClick.AutoSize = true;
            this.lblPerfilClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfilClick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblPerfilClick.Location = new System.Drawing.Point(12, 111);
            this.lblPerfilClick.Name = "lblPerfilClick";
            this.lblPerfilClick.Size = new System.Drawing.Size(61, 25);
            this.lblPerfilClick.TabIndex = 2;
            this.lblPerfilClick.Text = "Perfil";
            this.lblPerfilClick.Click += new System.EventHandler(this.lblPerfilClick_Click);
            // 
            // PerfilEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 416);
            this.Controls.Add(this.lblPerfilClick);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.lblPerfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PerfilEmpresa";
            this.Text = "PerfilEmpresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblPerfilClick;
    }
}